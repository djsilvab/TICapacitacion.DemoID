namespace TICapacitacion.DemoID.Biblioteca;

public interface IDelegateWriter
{
    Action<string> Delegate { get; set; }
}

