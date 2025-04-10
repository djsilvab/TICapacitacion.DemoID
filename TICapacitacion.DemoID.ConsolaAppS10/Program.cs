using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TICapacitacion.DemoID.BibliotecaS10;
using TICapacitacion.DemoID.BibliotecaS9;
using TICapacitacion.DemoID.BibliotecaS9.Interfaces;

var builder = Host.CreateApplicationBuilder();
builder.Services.AddMLibraryServices();

builder.Services.AddLogging(config =>
{
    config.ClearProviders();

    config.AddCustomConsoleLogger();

    //config.AddConsole()
    //      .AddSimpleConsole(cfg =>
    //      {
    //          cfg.IncludeScopes = true;
    //      });
});

using var HostApplication = builder.Build();

Console.WriteLine("\nScope 1:");
ExemplifyServiceLifeTime(HostApplication.Services, "Lifetime 1");

Console.WriteLine("\nScope 2:");
ExemplifyServiceLifeTime(HostApplication.Services, "Lifetime 2");

Console.WriteLine();

void ExemplifyServiceLifeTime(IServiceProvider serviceProvider, string lifetime)
{
    using IServiceScope serviceScope = serviceProvider.CreateScope();
    IServiceProvider scopeProvider = serviceScope.ServiceProvider;
    IServiceLifeTimeReporter reporter;

    reporter = scopeProvider.GetRequiredService<IServiceLifeTimeReporter>();
    reporter.ReportServiceLifeTimeDetails(lifetime, "Call 1 to " +
        "ReportServiceLifeTimeDetails");

    reporter = scopeProvider.GetRequiredService<IServiceLifeTimeReporter>();
    reporter.ReportServiceLifeTimeDetails(lifetime, "Call 2 to " +
        "ReportServiceLifeTimeDetails");

}