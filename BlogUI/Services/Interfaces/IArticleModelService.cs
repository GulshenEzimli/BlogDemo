using BlogUI.Models.Article;
using Entity.Concrete;

namespace BlogUI.Services.Interfaces
{
	public interface IArticleModelService : IControlModelService<Article,ArticleModel>
	{
		List<ArticleModel> GetAllArticlesWithIncludes();
		ArticleModel GetArticleWithIncludes(int id);
        List<ArticleModel> LastArticlesOfWriter(int id);
		List<ArticleModel> GetLastThree();

    }
}
