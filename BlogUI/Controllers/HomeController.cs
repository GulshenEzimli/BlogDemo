using BlogUI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAboutModelService _aboutModelService;
        private readonly IContactModelService _contactModelService;
        public HomeController(IAboutModelService aboutModelService, IContactModelService contactModelService)
        {
            _aboutModelService = aboutModelService;
            _contactModelService = contactModelService;
        }

        [HttpGet]
        public IActionResult About()
        {
            var abouts = _aboutModelService.GetAll();
            return View(abouts);
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var abouts = _contactModelService.GetAll();
            return View(abouts);
        }
    }
}
