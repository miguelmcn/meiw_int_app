using EuroMilApp.Domain;
using EuroMilApp.Infrastructure.Data.Gateways;
using EuroMilApp.Infrastructure.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EuroMilApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(ServiceProvider.GetRequiredService<BetScreen>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    var settingsFileName = "/appsettings.json";
#if DEBUG
                    settingsFileName = "/appsettings.Development.json";
#endif

                    var settingsFile = File.ReadAllText(Application.StartupPath + settingsFileName);
                    var appOptions = System.Text.Json.JsonSerializer.Deserialize<ApplicationOptions>(settingsFile);

                    services.AddSingleton(appOptions);


                    services.AddSingleton<CrediBankGateway>();
                    services.AddSingleton<EuroMilRegisterGateway>();

                    services.AddSingleton<BetService>();

                    services.AddTransient<BetScreen>();
                });
        }
    }
}