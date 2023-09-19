using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Repeat
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new HostBuilder().ConfigureServices((hostingContext, services) =>
           {
               services.AddHostedService<RepeatScheduler>();
           });

            await builder.RunConsoleAsync();
        }

    }
}