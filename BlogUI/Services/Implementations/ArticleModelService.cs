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

		
		public List<ArticleModel> GetAllArticlesWithIncludes()
		{
			var articles = _articleService.GetAllArticlesWithIncludes();
			List<ArticleModel> models = new List<ArticleModel>();
			foreach (var article in articles)
			{
				var articleModel = _articleMapper.Map(article);
				models.Add(articleModel);
			}

			return models;
		}

        public ArticleModel GetArticleWithIncludes(int id)
        {
			var article = _articleService.GetArticleWithIncludes(id);
			var articleModel = _articleMapper.Map(article);

			return articleModel;

        }

        public List<ArticleModel> LastArticlesOfWriter(int id)
        {
           var articles = _articleService.LastArticlesOfWriter(id);
			List<ArticleModel> models = new List<ArticleModel>();
			foreach (var article in articles)
			{
				var model = _articleMapper.Map(article);
				models.Add(model);
			}
			return models;
        }

        public List<ArticleModel> GetLastThree()
        {
			var articles = _articleService.GetLastThree();
            List<ArticleModel> models = new List<ArticleModel>();
            foreach (var article in articles)
            {
                var model = _articleMapper.Map(article);
                models.Add(model);
            }
            return models;
        }
    }
}
