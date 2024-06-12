using BlogUI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAboutModelService _aboutModelService;

        public HomeController(IAboutModelService aboutModelService)
        {
            _aboutModelService = aboutModelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            var abouts = _aboutModelService.GetAll();
            return View(abouts);
        }
    }
}
