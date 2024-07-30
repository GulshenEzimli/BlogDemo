using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.DbContexts;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
	public class CommentRepository : EfEntityRepository<Comment, BlogDbContext>,ICommentRepository
	{
		private readonly BlogDbContext _dbContext;

		public CommentRepository(BlogDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public List<Comment> ArticleCommentsWithUser(int id)
		{
			return _dbContext.Set<Comment>().Include(comment => comment.User).Where(c => c.ArticleId == id).ToList();

		}
	}
}
