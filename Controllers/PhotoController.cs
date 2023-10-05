using Microsoft.AspNetCore.Mvc;

namespace PKSS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhotoController : Controller
    {
        private const string pathPhoto = "MIREA_Gerb_Colour.png";

        [HttpGet("Get")]
        async public Task<IActionResult> GetPhotoForPath()
        {
            string contentType = "image/png";
            byte[] photoBytes = System.IO.File.ReadAllBytes(pathPhoto);

            return File(photoBytes, contentType);
        }
    }
}
