using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
