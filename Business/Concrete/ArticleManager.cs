using Business.Abstract;
using Core.Business.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;


namespace Business.Concrete
{
	public class ArticleManager : EntityManager<Article>, IArticleService
	{
        public ArticleManager(IArticleRepository articleRepository) : base(articleRepository)
        {
        }
    }
}
