using Microsoft.Extensions.Logging;
using TICapacitacion.DemoID.BibliotecaS9.Interfaces;

namespace TICapacitacion.DemoID.BibliotecaS9.Implementations;

public class ServiceLifeTimeReporter(
        IExampleTransientService transientService,
        IExampleScopedService scopedService,
        IExampleSingletonService singletonService,
        ILogger<ServiceLifeTimeReporter> logger
    ) : IServiceLifeTimeReporter
{
    public void ReportServiceLifeTimeDetails(string lifetime, string details)
    {
        //BeginScope: permite agrupar los mensajes
        using var S = logger.BeginScope("{0}: {1}", lifetime, details);

        LogServiceInfo(transientService, "Always different");
        LogServiceInfo(scopedService, "Changes only with lifetime");
        LogServiceInfo(singletonService, "Always the same");
    }

    void LogServiceInfo<T>(T service, string message)
        where T : IReportServiceLifeTime
        => logger.LogInformation("\t {type}: {id}\n\t ({message})", typeof(T).Name, service.Id, message);

}
