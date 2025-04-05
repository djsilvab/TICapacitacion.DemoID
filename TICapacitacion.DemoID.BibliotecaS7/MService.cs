using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace TICapacitacion.DemoID.BibliotecaS7;
public class MService(ILogger<MService> logger,
                      IConfiguration configuration) : IDisposable
{
    public void LogMessage(string message) 
        => logger.LogInformation(message);

    public void LogConfigKeyValue(string key)
        => logger.LogInformation("MService.LogConfigKeyValue: {value}", configuration[key]);

    public void Dispose()
    {
        logger.LogInformation("MService Disposed");
    }
}
