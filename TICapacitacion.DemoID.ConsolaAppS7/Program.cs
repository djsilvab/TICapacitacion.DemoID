using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TICapacitacion.DemoID.BibliotecaS7;

//RunWithoutApplicationHost();
//RunWithApplicationHost();
RunCreateApplicationBuilderExample();

void RunCreateApplicationBuilderExample()
{
    Console.WriteLine("With Application Builder Example");
    var Builder = Host.CreateApplicationBuilder();
    Builder.Services.AddSingleton<MService>();

    using IHost AppHost = Builder.Build();
    MHelperService.DoSomeWork(AppHost.Services);
}

void RunWithApplicationHost()
{
    Console.WriteLine("With Application Host Example");
    IHostBuilder Builder = Host.CreateDefaultBuilder();
    Builder.ConfigureServices(services =>
    {
        services.AddSingleton<MService>();
    });
    using IHost AppHost = Builder.Build();
    MHelperService.DoSomeWork(AppHost.Services);
}

void RunWithoutApplicationHost()
{
    Console.WriteLine("Without Application Host Example");
    IServiceCollection Services = new ServiceCollection();
    
    Services.AddLogging(config => 
    {
        config.AddConsole();
        config.AddDebug();
    });

    IConfiguration Config = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json")
                                .Build();

    Services.AddSingleton(Config);
    Services.AddSingleton<MService>();

    ServiceProvider Provider = Services.BuildServiceProvider();

    MHelperService.DoSomeWork(Provider);

    Provider.Dispose();
}