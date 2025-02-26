using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TICapacitacion.DemoID.Biblioteca;

namespace TICapacitacion.DemoID.WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder();
            builder.Services.AddHostedService<Worker>();
            builder.Services.AddSingleton<Form1>();

            builder.Services.AddSingleton<DelegateMessageWriter>();
            builder.Services.AddSingleton<IMessageWriter>(provider =>
                provider.GetRequiredService<DelegateMessageWriter>()
            );
            builder.Services.AddSingleton<IDelegateWriter>(provider =>
                provider.GetRequiredService<DelegateMessageWriter>()
            );

            using IHost AppHost = builder.Build();
            AppHost.RunAsync();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(AppHost.Services.GetRequiredService<Form1>());
        }
    }
}