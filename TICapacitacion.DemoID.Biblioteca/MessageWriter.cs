namespace TICapacitacion.DemoID.Biblioteca;

public class MessageWriter : IMessageWriter
{
    public void Write(string message)
    {
        Console.WriteLine($"MessageWriter.Writer: {message}");
    }
}
