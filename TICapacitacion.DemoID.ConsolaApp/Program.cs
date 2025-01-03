using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TICapacitacion.DemoID.Biblioteca;

var builder = Host.CreateApplicationBuilder();
builder.Services.AddSingleton<IMessageWriter, MessageWriter>();
builder.Services.AddSingleton<Worker>();

using IHost AppHost = builder.Build();
var cts = new CancellationTokenSource();
var ct = cts.Token;

var worker = AppHost.Services.GetRequiredService<Worker>();
_ = worker.ExecuteAsync(cts.Token);

Console.WriteLine("Press <enter> to cancel worker...");
Console.ReadLine();
cts.Cancel();

Console.ReadLine();

AppHost.Run();
