using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WinFormsAppDI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            var host= Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddTransient<IHelloDI, HelloDI>();
                    services.AddTransient<MainForm>();
                });

            return host;
        }
    }
}