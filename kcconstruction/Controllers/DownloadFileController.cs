
using Microsoft.AspNetCore.Mvc;

namespace kcconstruction.Controllers
{
    public class DownloadFileController : Controller
    {
        public IActionResult DownloadFile()
        {
            return File("/images/kovalD.jpg", "application/octet-stream", "kovalD.jpg");
        }
    }
}