using BlogUI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
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

		[AllowAnonymous]
		public IActionResult Index()
		{
			var articleModels = _articleService.GetAllArticlesWithIncludes();
			
			return View(articleModels);
		}

		public IActionResult ArticleDetails(int id)
		{
			var articleModel = _articleService.GetArticleWithIncludes(id);
			return View(articleModel);
		}
	}
}
