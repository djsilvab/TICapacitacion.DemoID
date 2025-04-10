using Microsoft.Extensions.DependencyInjection;
using TICapacitacion.DemoID.BibliotecaS9.Interfaces;

namespace TICapacitacion.DemoID.BibliotecaS9.Implementations;

public class ExampleTransientService : IExampleTransientService
{
    public ExampleTransientService()
        => (Id, LifeTime) = (Guid.NewGuid(), ServiceLifetime.Transient);

    public Guid Id { get; }

    public ServiceLifetime LifeTime { get; }
}
