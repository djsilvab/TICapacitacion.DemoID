using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace TICapacitacion.DemoID.BibliotecaS4;

public class ExampleService
{
    public ExampleService()
    {
        Console.WriteLine("{0} was selected.", "ExampleService()");
    }

    public ExampleService(ILogger<ExampleService> logger)
    {
        Console.WriteLine("{0} was selected.", "ExampleService(ILogger<ExampleService> logger)");
    }

    public ExampleService(FooService fooService, BarService barService)
    {
        Console.WriteLine("{0} was selected.", "ExampleService(FooService fooService, BarService barService)");
    }

    public ExampleService(IOptions<ExampleOptions> options)
    {
        Console.WriteLine("{0} was selected.", "ExampleService(IOptions<ExampleOptions> options)");
    }

    public ExampleService(ILogger<ExampleService> logger,
        IOptions<ExampleOptions> options)
    {
        Console.WriteLine("{0} was selected.", "ExampleService(ILogger<ExampleService> logger, IOptions<ExampleOptions> options)");
    }
}
