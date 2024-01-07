using Microsoft.AspNetCore.Mvc;
using StreamFlex.DownloadWorker.Services;
using System.Threading.Tasks;

namespace StreamFlex.DownloadWorker.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DownloadController : ControllerBase
    {
        private readonly DownloadService _downloadService;

        public DownloadController(DownloadService downloadService)
        {
            _downloadService = downloadService;
        }

        [HttpPost("download-video")]
        public async Task<IActionResult> DownloadVideo([FromBody] string videoUrl)
        {
            try
            {
                // todo: Тут можна додати додаткову валідацію URL
                await _downloadService.DownloadVideoFromUrl(videoUrl);
                return Ok($"Завантаження відео розпочато для URL: {videoUrl}");
            }
            catch (Exception ex)
            {
                // Обробка помилок
                return BadRequest(ex.Message);
            }
        }
    }
}