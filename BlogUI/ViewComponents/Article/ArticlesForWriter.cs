using BlogUI.Mappers.Interfaces;
using BlogUI.Services.Interfaces;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.Article
{
	public class ArticlesForWriter : ViewComponent
	{
        public readonly IArticleModelService _articleService;
        public ArticlesForWriter(IArticleModelService service)
		{
            _articleService = service;
		}

		public IViewComponentResult Invoke(int id)
		{
			var articles = _articleService.LastArticlesOfWriter(id);
			
			return View(articles);
		}
	}
}
