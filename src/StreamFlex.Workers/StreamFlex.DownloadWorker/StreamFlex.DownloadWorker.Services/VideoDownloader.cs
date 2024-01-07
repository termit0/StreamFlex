using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace StreamFlex.DownloadWorker.Services;

public class VideoDownloader
{
    public async Task DownloadVideoAsync(string url, string outputPath)
    {
        var youtube = new YoutubeClient();
        var videoId = GetYouTubeVideoId(url);
        if (videoId != null)
        {
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            var httpClient = new HttpClient();
            var stream = await httpClient.GetStreamAsync(streamInfo.Url);
            var filePath = Path.Combine(outputPath, $"{videoId}.mp4");

            await using var fileStream = File.OpenWrite(filePath);
            await stream.CopyToAsync(fileStream);
        }
    }

    private static string? GetYouTubeVideoId(string url)
    {
        var uri = new Uri(url);
        var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
        if (query.AllKeys.Contains("v"))
        {
            return query["v"];
        }
        else
        {
            string?[] segments = uri.Segments;
            return segments[^1];
        }
    }
}