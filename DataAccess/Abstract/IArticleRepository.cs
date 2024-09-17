using Core.DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
	public interface IArticleRepository :IEntityRepository<Article>
	{
		Article GetArticleWithIncludes(int id);
		List<Article> GetAllArticlesWithIncludes();
		List<Article> GetLastThree();
		List<Article> LastArticlesOfWriter(int id);
        Article GetArticleWithUniqueId(Guid guid);
	}
}
