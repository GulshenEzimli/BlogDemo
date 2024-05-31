using Core.Business.Abstract;
using Entity.Concrete;

namespace Business.Abstract
{
	public interface IArticleService : IEntityService<Article>
	{
		List<Article> GetListWithCategpories();
	}
}
