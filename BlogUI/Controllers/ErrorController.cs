using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index([FromQuery] int code)
        {
            return View();
        }
    }
}
