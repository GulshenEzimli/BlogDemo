using Business.Abstract;
using Core.Business.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
	public class CommentManager : EntityManager<Comment>, ICommentService
	{
        public CommentManager(ICommentRepository commentRepository) : base(commentRepository)
        {
        }
    }
}
