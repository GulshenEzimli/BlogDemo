using Core.Business.Abstract;
using Entity.Concrete;

namespace Business.Abstract
{
	public interface IArticleService : IEntityService<Article>
	{
		Article GetArticleWithIncludes(int id);
		List<Article> GetAllArticlesWithIncludes();
		List<Article> GetLastThree();
		List<Article> LastArticlesOfWriter(int id);
        Article GetArticleWithUniqueId(Guid guid);
	}
}
