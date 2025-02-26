using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TICapacitacion.DemoID.Biblioteca;

public class Worker(IMessageWriter writer) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            //logger.LogInformation("Worker running at: {time}", DateTime.Now.TimeOfDay);
            writer.Write($"Worker running at: {DateTime.Now.TimeOfDay}");
            await Task.Delay(1000, cancellationToken)
                      .ConfigureAwait(ConfigureAwaitOptions.SuppressThrowing);
        }
    }
}