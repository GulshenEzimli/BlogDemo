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
        public  IViewComponentResult Invoke()
        {
            var articles = _articleService.GetLastThree();

            return  View(articles);
        }
    }
}
