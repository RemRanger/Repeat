using Microsoft.Extensions.Hosting;

namespace Repeat
{
    internal class RepeatScheduler : BackgroundService
    {
        private const double HourInterval = 2.0 / 3600; // Two seconds for the example; most applications will need quite a higher interval, in the order of hours.

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Console.WriteLine("Fire.");
                // Do your thing here

                await Task.Delay(TimeSpan.FromHours(HourInterval), stoppingToken);
            }
        }

    }
}
