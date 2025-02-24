using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TICapacitacion.DemoID.Biblioteca;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

Builder.Services.AddHostedService<Worker>();

//Builder.Services.AddLogging(config => { 
//    config.ClearProviders();
//    config.AddDebug();
//});

using IHost AppHost = Builder.Build();

AppHost.Run();