using Microsoft.Extensions.Logging;

namespace TICapacitacion.DemoID.Biblioteca;

public class LoggingMessageWriter(ILogger<LoggingMessageWriter> logger)
    : IMessageWriter
{
    public void Write(string message)
    {
        logger.LogInformation("LoggingMessageWriter: {msg}", message);
    }
}