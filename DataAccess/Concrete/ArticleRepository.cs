using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.DbContexts;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
	public class ArticleRepository : EfEntityRepository<Article>, IArticleRepository
	{
		private readonly DbContext _dbContext;

		public ArticleRepository(DbContext dbContext) : base(dbContext)
		{
			_dbContext = dbContext;
		}

		public List<Article> GetArticlesWithCategory()
		{
			return _dbContext.Set<Article>().Include(x => x.Category).ToList();
		}
	}
}
