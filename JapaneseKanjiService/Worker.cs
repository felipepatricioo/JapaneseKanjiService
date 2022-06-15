
namespace JapaneseKanjiService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly JapaneseService _japaneseService;

        public Worker(
        JapaneseService japaneseService,
        ILogger<Worker> logger) =>
        (_japaneseService, _logger) = (japaneseService, logger);

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                string greeting = _japaneseService.GetKanji();
                _logger.LogInformation(greeting);

                await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
            }
        }
    }
}
