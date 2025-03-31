
var builder = WebApplication.CreateBuilder();

builder.Services.AddServicesLibrary();

using var App = builder.Build();

App.MapGet("{*path}",
            async (HttpContext context, IRequestProcessor processor) =>
            {
                await context.Response.WriteAsync(
                    processor.ProcessRequest(context.Request)
                );
            });

App.Run();