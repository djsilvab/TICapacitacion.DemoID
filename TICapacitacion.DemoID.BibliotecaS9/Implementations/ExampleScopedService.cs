using Microsoft.Extensions.DependencyInjection;
using TICapacitacion.DemoID.BibliotecaS9.Interfaces;

namespace TICapacitacion.DemoID.BibliotecaS9.Implementations;

public class ExampleScopedService : IExampleScopedService
{
    public ExampleScopedService()
        => (Id, LifeTime) = (Guid.NewGuid(), ServiceLifetime.Scoped);

    public Guid Id { get; }

    public ServiceLifetime LifeTime { get; }
}
