using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TICapacitacion.DemoID.BibliotecaS9.Interfaces;

namespace TICapacitacion.DemoID.BibliotecaS9.Implementations;

public class ExampleSingletonService : IExampleSingletonService
{
    public ExampleSingletonService()
        => (Id, LifeTime) = (Guid.NewGuid(), ServiceLifetime.Singleton);

    public Guid Id { get; }

    public ServiceLifetime LifeTime { get; }
}
