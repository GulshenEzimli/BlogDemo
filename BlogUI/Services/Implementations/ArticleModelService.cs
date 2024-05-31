using BlogUI.Mappers.Interfaces;
using BlogUI.Models.Article;
using BlogUI.Services.Interfaces;
using Business.Abstract;

namespace BlogUI.Services.Implementations
{
	public class ArticleModelService : IArticleModelService
	{
		private readonly IArticleMapper _mapper;
		private readonly IArticleService _service;

		public ArticleModelService(IArticleMapper mapper, IArticleService service)
		{
			_mapper = mapper;
			_service = service;
		}

		public ArticleModel GetById(int id)
		{
			var article = _service.GetById(a => a.Id == id);
			var model = _mapper.Map(article);
			return model;
		}

		public List<ArticleModel> GetAll()
		{
			var articles = _service.GetAll();
			List<ArticleModel> models = new List<ArticleModel>();
			foreach (var article in articles)
			{
				var articleModel = _mapper.Map(article);
				models.Add(articleModel);
			}

			return models;
		}

		public void Add(ArticleModel model)
		{
			var article = _mapper.Map(model);
			_service.Add(article);
		}

		public void Delete(int id)
		{
			_service.Delete(id);
		}

		public void Update(ArticleModel model)
		{
			var article = _mapper.Map(model);
			_service.Update(article);
		}

		public List<ArticleModel> GetAllArticles()
		{
			var articles = _service.GetListWithCategpories();
			List<ArticleModel> models = new List<ArticleModel>();
			foreach (var article in articles)
			{
				var articleModel = _mapper.Map(article);
				models.Add(articleModel);
			}

			return models;
		}
	}
}
