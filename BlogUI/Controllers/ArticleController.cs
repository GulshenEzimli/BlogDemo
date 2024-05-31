using BlogUI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	public class ArticleController : Controller
	{
		private readonly IArticleModelService _articleService;

		public ArticleController(IArticleModelService articleService)
		{
			_articleService = articleService;
		}

		public IActionResult Index()
		{
			var articleModels = _articleService.GetAllArticles();
			
			return View(articleModels);
		}

		public IActionResult ArticleDetails(int id)
		{
			var articleModel = _articleService.GetAllArticles().FirstOrDefault(x => x.Id == id);
			return View(articleModel);
		}
	}
}
