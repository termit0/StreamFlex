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
        // todo: Тут визначте шлях для збереження файлу
        var outputPath = "D:/tmp/";// todo: hard code
        await _videoDownloader.DownloadVideoAsync(url, outputPath);
    }
}