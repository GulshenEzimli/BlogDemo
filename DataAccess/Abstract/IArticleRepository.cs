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
		List<Article> GetArticlesWithCategory();
		List<Article> GetLastThree();
		List<Article> LastArticlesOfWriter(int id);
	}
}
