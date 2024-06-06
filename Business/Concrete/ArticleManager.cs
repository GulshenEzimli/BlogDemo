using Business.Abstract;
using Core.Business.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
	public class ArticleManager : EntityManager<Article>, IArticleService
	{
		private readonly IArticleRepository _articleRepository;

		public ArticleManager(IArticleRepository articleRepository) : base(articleRepository)
        {
			_articleRepository = articleRepository;
        }

		public List<Article> GetListWithCategories()
		{
			return _articleRepository.GetArticlesWithCategory();
		}

		public List<Article> GetArticlesWithWriterId(int id)
		{
			return this.GetListWithCategories().Where(a => a.WriterId == id).ToList();
		}
	}
}
