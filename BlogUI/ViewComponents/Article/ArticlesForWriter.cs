using BlogUI.Mappers.Interfaces;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.Article
{
	public class ArticlesForWriter : ViewComponent
	{
		private readonly IArticleService _service;
		private readonly IArticleMapper _mapper;
		public ArticlesForWriter(IArticleService service, IArticleMapper mapper)
		{
			_service = service;
			_mapper = mapper;
		}

		public IViewComponentResult Invoke(int id)
		{
			var articles = _service.GetArticlesWithWriterId(id).Select(a => _mapper.Map(a)).OrderBy(a => a.UpdatedDate).ToList();
			
			if (articles.Count > 3)
				articles = articles.GetRange(articles.Count-3, 3);

			return View(articles);
		}
	}
}
