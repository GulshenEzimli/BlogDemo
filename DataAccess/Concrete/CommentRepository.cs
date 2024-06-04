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
	public class CommentRepository : EfEntityRepository<Comment>,ICommentRepository
	{
		private readonly DbContext _dbContext;

		public CommentRepository(DbContext dbContext) :	base(dbContext)
		{
			_dbContext = dbContext;
		}

		public List<Comment> ArticleCommentsWithUser(Expression<Func<Comment, bool>> filter)
		{
			return _dbContext.Set<Comment>().Include(comment => comment.User).Where(filter).ToList();

		}
	}
}
