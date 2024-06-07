using BlogUI.Mappers.Interfaces;
using BlogUI.Models.Article;
using BlogUI.Services.Interfaces;
using Business.Abstract;
using Entity.Concrete;

namespace BlogUI.Services.Implementations
{
	public class ArticleModelService : ControlModelService<Article,ArticleModel>, IArticleModelService
	{
		private readonly IArticleMapper _articleMapper;
		private readonly IArticleService _articleService;

		public ArticleModelService(IArticleMapper articleMapper, IArticleService articleService) : base(articleMapper,articleService)
		{
            _articleMapper = articleMapper;
            _articleService = articleService;
		}

		
		public List<ArticleModel> GetAllArticles()
		{
			var articles = _articleService.GetListWithCategories();
			List<ArticleModel> models = new List<ArticleModel>();
			foreach (var article in articles)
			{
				var articleModel = _articleMapper.Map(article);
				models.Add(articleModel);
			}

			return models;
		}
	}
}
