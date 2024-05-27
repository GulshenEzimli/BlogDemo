using BlogUI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ICategoryModelService _categoryService;
        public CategoryController(ICategoryModelService categoryService)
        {
			_categoryService = categoryService;
        }
        public IActionResult Index()
		{
			var categories = _categoryService.GetAll();
			return View(categories);
		}
	}
}
