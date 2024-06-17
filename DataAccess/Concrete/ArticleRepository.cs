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

		public List<Article> GetAllArticlesWithIncludes()
		{
			return _dbContext.Set<Article>().Include(a => a.Writer).Include(x => x.Category).ToList();
		}

        public List<Article> GetLastThree()
        {
            return _dbContext.Set<Article>().Include(a => a.Category).Include(a => a.Writer).OrderByDescending(x => x.UpdatedDate).Take(3).ToList();
        }

        public List<Article> LastArticlesOfWriter(int id)
        {
            return _dbContext.Set<Article>().Include(a => a.Writer).Include(a => a.Category).Where(a => a.WriterId == id).OrderByDescending(x => x.UpdatedDate).Take(3).ToList();

        }

        public Article GetArticleWithIncludes(int id)
        {
            return _dbContext.Set<Article>().Include(a => a.Writer).Include(a => a.Category).FirstOrDefault(a => a.Id == id);
        }
    }
}
