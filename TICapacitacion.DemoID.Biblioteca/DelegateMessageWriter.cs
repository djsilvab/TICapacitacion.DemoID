namespace TICapacitacion.DemoID.Biblioteca;

public class DelegateMessageWriter : IMessageWriter, IDelegateWriter
{
    public Action<string> Delegate { get; set; }

    public void Write(string message)
    {
        Delegate?.Invoke(message);
    }
}