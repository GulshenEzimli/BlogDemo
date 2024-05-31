using BlogUI.Models.Article;

namespace BlogUI.Services.Interfaces
{
	public interface IArticleModelService : IControlModelService<ArticleModel>
	{
		List<ArticleModel> GetAllArticles();
	}
}
