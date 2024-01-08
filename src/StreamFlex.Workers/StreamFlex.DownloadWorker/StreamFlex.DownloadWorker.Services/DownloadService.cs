namespace StreamFlex.DownloadWorker.Services;

public class DownloadService
{
    private readonly VideoDownloader _videoDownloader;

    public DownloadService()
    {
        _videoDownloader = new VideoDownloader();// todo: need to use DI
    }

    public async Task DownloadVideoFromUrl(string url)
    {
        var outputPath = Environment.GetEnvironmentVariable("OUTPUT_PATH");
        await _videoDownloader.DownloadVideoAsync(url, outputPath);
    }
}