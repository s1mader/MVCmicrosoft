using Microsoft.AspNetCore.Mvc;

namespace MVCmicrosoft.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult NotFound(string url)
        {
            ViewBag.RequestedUrl = url;
            return View();
        }
    }
}
