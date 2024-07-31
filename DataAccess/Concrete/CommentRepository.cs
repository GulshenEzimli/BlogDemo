using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.DbContexts;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
	public class CommentRepository : EfEntityRepository<Comment, BlogDbContext>,ICommentRepository
	{
		public List<Comment> ArticleCommentsWithUser(int id)
		{
            using (BlogDbContext context = new BlogDbContext())
            {
                return context.Set<Comment>().Include(comment => comment.User).Where(c => c.ArticleId == id).ToList();
            }
        }
	}
}
