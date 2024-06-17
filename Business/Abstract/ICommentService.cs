using Entity.Concrete;
using Core.Business.Abstract;
using System.Linq.Expressions;

namespace Business.Abstract
{
	public interface ICommentService: IEntityService<Comment>
	{
		List<Comment> ArticleCommentsWithUser(int id);
	}
}
