using Microsoft.Extensions.DependencyInjection;

namespace TICapacitacion.DemoID.BibliotecaS4;
public static class DependencyContainer
{
    public static IServiceCollection AddLibraryServices(this IServiceCollection services)
    {
        services.AddSingleton<IExampleService,ExampleService>();
        services.AddOptions<ExampleOptions>();

        return services;
    }
}
