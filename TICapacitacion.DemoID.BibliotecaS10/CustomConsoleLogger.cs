using Microsoft.Extensions.Logging;
using System.Text;

namespace TICapacitacion.DemoID.BibliotecaS10;

internal sealed class CustomConsoleLogger(string categoryName) : ILogger
{
    public int Scopes = 0;

    public IDisposable BeginScope<TState>(TState state)
    {
        StringBuilder messageBuilder = new StringBuilder();
        messageBuilder.AppendFormat("\n{0}", new string('\t', Scopes));
        messageBuilder.AppendFormat("[{0}]", categoryName);
        messageBuilder.AppendFormat("\n{0}", new string('\t', Scopes));
        messageBuilder.Append(state);

        Console.WriteLine(messageBuilder);

        Scopes++;
        return new DisposableScope(this);
    }

    public bool IsEnabled(LogLevel logLevel)
        => logLevel >= LogLevel.Information;

    public void Log<TState>(
        LogLevel logLevel,
        EventId eventId,
        TState state,
        Exception exception,
        Func<TState, Exception, string> formatter)
    {
        if (IsEnabled(logLevel))
        {
            Console.Write(new string('\t', Scopes));
            Console.WriteLine(formatter(state, exception));
        }
    }
}

class DisposableScope(CustomConsoleLogger logger) : IDisposable
{
    public void Dispose()
    {
        logger.Scopes--;
    }
}
