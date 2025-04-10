using Microsoft.Extensions.DependencyInjection;

namespace TICapacitacion.DemoID.BibliotecaS9.Interfaces;

public interface IReportServiceLifeTime
{
    Guid Id { get; }
    ServiceLifetime LifeTime { get; }
}
