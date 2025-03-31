
var builder = WebHost.CreateDefaultBuilder();

builder.UseStartup<Startup>();

using var AppHost  = builder.Build();

AppHost.Run();