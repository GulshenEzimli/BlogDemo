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

        [HttpGet]
		public IActionResult ArticleDetails(Guid uid)
		{
			var articleModel = _articleService.GetArticleWithUniqueId(uid);
			return View(articleModel);
		}
	}
}
