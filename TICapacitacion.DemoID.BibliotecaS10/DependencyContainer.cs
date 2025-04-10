using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TICapacitacion.DemoID.BibliotecaS10;
public static class DependencyContainer
{
    public static ILoggingBuilder AddCustomConsoleLogger(this ILoggingBuilder builder)
    {
        builder.Services.AddSingleton<ILoggerProvider, CustomConsoleLoggerProvider>();
        
        return builder;
    }
}
