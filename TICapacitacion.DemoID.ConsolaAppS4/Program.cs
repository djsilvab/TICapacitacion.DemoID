using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TICapacitacion.DemoID.BibliotecaS4;

var builder = Host.CreateApplicationBuilder();
builder.Services.AddSingleton<ExampleService>();

using IHost AppHost = builder.Build();
var exampleService = AppHost.Services.GetRequiredService<ExampleService>();

Console.WriteLine();
Console.WriteLine("Presiona <enter> para finalizar.");
Console.ReadLine();