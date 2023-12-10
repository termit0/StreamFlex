namespace StreamFlex.DownloadWorker;

public class DownloadWorker : BackgroundService
{
    private readonly ILogger<DownloadWorker> _logger;

    public DownloadWorker(ILogger<DownloadWorker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("DownloadWorker running at: {time}", DateTimeOffset.Now);
            await Task.Delay(1000, stoppingToken);
        }
    }
}
