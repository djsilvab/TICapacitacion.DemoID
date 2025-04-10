using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TICapacitacion.DemoID.BibliotecaS10;

internal class CustomConsoleLoggerProvider : ILoggerProvider
{
    public ILogger CreateLogger(string categoryName)
        => new CustomConsoleLogger(categoryName);

    public void Dispose() { }
}
