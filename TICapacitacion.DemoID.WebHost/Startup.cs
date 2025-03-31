namespace TICapacitacion.DemoID.WebHost;
internal class Startup
{
    public void ConfigureService(IServiceCollection services)
    {
        services.AddServicesLibrary();
    }

    public void Configure(IApplicationBuilder app, IRequestProcessor processor)
    {
        app.Run(async context =>
        {
            await context.Response.WriteAsync(processor.ProcessRequest(context.Request));
        });
    }
}