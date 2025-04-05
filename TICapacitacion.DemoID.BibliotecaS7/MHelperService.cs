using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace TICapacitacion.DemoID.BibliotecaS7;

public class MHelperService
{   
    public static void DoSomeWork(IServiceProvider provider)
    {
        ILogger logger = provider.GetRequiredService<ILoggerFactory>()
                                           .CreateLogger("\t***Logging");

        ILogger<MHelperService> genericLogger = provider.GetRequiredService<ILogger<MHelperService>>();

        logger.LogInformation("Message from ILogger");

        genericLogger.LogInformation("Message from GenericLogger");

        IConfiguration Configuration = provider.GetRequiredService<IConfiguration>();
        string Value = Configuration["KeyDemo"];
        logger.LogInformation("Logger - Key Demo Value : {value}", Value);
        genericLogger.LogInformation("GenericLogger - Key Demo Value : {value}", Value);

        var service = provider.GetRequiredService<MService>();
        service.LogMessage("Message from MService");
        service.LogConfigKeyValue("KeyDemo");
    }
}
