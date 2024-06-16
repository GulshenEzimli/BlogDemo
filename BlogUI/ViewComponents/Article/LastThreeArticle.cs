using BlogUI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.Article
{
    public class LastThreeArticle : ViewComponent
    {
        public readonly IArticleModelService _articleService;
        public LastThreeArticle(IArticleModelService articleService)
        {
            _articleService = articleService;
        }
        public IViewComponentResult Invoke()
        {
            var articles = _articleService.GetAllArticles().OrderBy(a => a.UpdatedDate).ToList();

            if (articles.Count > 3)
                articles = articles.TakeLast(3).ToList();
            return View(articles);
        }
    }
}
