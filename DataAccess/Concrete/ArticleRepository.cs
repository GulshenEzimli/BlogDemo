using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.DbContexts;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
	public class ArticleRepository : EfEntityRepository<Article, BlogDbContext>, IArticleRepository
	{
        public List<Article> GetAllArticlesWithIncludes()
		{
            using (BlogDbContext context = new BlogDbContext())
            {
                return context.Set<Article>().Include(a => a.Writer).Include(x => x.Category).ToList();
            }
        }

        public List<Article> GetLastThree()
        {
            using (BlogDbContext context = new BlogDbContext())
            {
                return context.Set<Article>().Include(a => a.Category).Include(a => a.Writer).OrderByDescending(x => x.UpdatedDate).Take(3).ToList();
            }
        }

        public List<Article> LastArticlesOfWriter(int id)
        {
            using (BlogDbContext context = new BlogDbContext())
            {
                return context.Set<Article>().Include(a => a.Writer).Include(a => a.Category).Where(a => a.WriterId == id).OrderByDescending(x => x.UpdatedDate).Take(3).ToList();
            }
        }

        public Article GetArticleWithIncludes(int id)
        {
            using (BlogDbContext context = new BlogDbContext())
            {
                return context.Set<Article>().Include(a => a.Writer).Include(a => a.Category).FirstOrDefault(a => a.Id == id);
            }
        }

        public Article GetArticleWithUniqueId(Guid guid)
        {
            using (BlogDbContext context = new BlogDbContext())
            {
                return context.Set<Article>().Include(a => a.Writer).Include(a => a.Category).FirstOrDefault(a => a.UniqueId == guid);
            }
        }
    }
}
