using HW.API;
using HW.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace HW.Console
{
    class Program
    {
        static string _service;
        static string _message;
        static IMessageWriterService _messageService;
        static IMessageProvider _messageProvider;

        static async Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();

            // get the message service
            _messageService = _service.ToLower() switch
            {
                "console" => new ConsoleService(),
                "database" => new DatabaseService(),
                _ => new ConsoleService(),
            };

            // get the message provider
            _messageProvider = _message.ToLower() switch
            {
                "console" => new ConsoleMessageProvider(),
                "mobile" => new MobileMessageProvider(),
                "web" => new WebMessageProvider(),
                "windowsservice" => new WindowsServiceMessageProvider(),
                _ => new ConsoleMessageProvider()
            };

            // write the message
            _messageService.Write(_messageProvider.GetMessage());
            await host.RunAsync();
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostingContext, configuration) =>
            {
                configuration.Sources.Clear();

                configuration
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                IConfigurationRoot configurationRoot = configuration.Build();

                // get the configured implementations
                _message = configurationRoot["MessageImplementation"];
                _service = configurationRoot["ServiceImplementation"];

            });
    }
}
