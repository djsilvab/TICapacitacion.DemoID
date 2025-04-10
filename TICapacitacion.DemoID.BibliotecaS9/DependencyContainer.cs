using Microsoft.Extensions.DependencyInjection;
using TICapacitacion.DemoID.BibliotecaS9.Implementations;
using TICapacitacion.DemoID.BibliotecaS9.Interfaces;

namespace TICapacitacion.DemoID.BibliotecaS9;
public static class DependencyContainer
{
    public static IServiceCollection AddMLibraryService(this IServiceCollection services)
    {
        services.AddTransient<IExampleTransientService, ExampleTransientService>();
        services.AddScoped<IExampleScopedService, ExampleScopedService>();
        services.AddSingleton<IExampleSingletonService, ExampleSingletonService>();


        services.AddTransient<IServiceLifeTimeReporter, ServiceLifeTimeReporter>();
        

        return services;
    }

}
