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

		public List<Article> GetAllArticlesWithIncludes()
		{
			return _articleRepository.GetAllArticlesWithIncludes();
		}

        public Article GetArticleWithIncludes(int id)
        {
            return _articleRepository.GetArticleWithIncludes(id);
        }

        public List<Article> GetLastThree()
        {
            return _articleRepository.GetLastThree();
        }

        public List<Article> LastArticlesOfWriter(int id)
        {
            return _articleRepository.LastArticlesOfWriter(id);
        }
    }
}
