using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TICapacitacion.DemoID.Biblioteca
{
    public class Worker(IMessageWriter messageWriter)
    {
        //private readonly IMessageWriter messageWriter;
        //private readonly MessageWriter MessageWriter = new MessageWriter();

        //public Worker(IMessageWriter messageWriter)
        //{
        //    this.messageWriter = messageWriter;
        //}

        public async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                messageWriter.Write($"Worker running at: {DateTime.Now.TimeOfDay}");
                await Task.Delay(1000, cancellationToken);
            }
        }

    }
}
