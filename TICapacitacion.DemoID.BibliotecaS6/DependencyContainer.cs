namespace TICapacitacion.DemoID.BibliotecaS6
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesLibrary(this IServiceCollection services)
        {
            services.AddSingleton<IRequestProcessor, RequestProcessor>();
            return services;
        }
    }
}
