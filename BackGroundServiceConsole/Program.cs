using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging.Configuration;
using Microsoft.Extensions.Logging.EventLog;

namespace BackGroundServiceConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddWindowsService(options =>
            {
                options.ServiceName = ".NET Joke Service";
            });

            builder.Services.AddSingleton<JokingService>();
            builder.Services.AddHostedService<TestBackground>();

            IHost host = builder.Build();
            host.Run();

        }
    }
}
