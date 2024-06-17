using Business.Abstract;
using Core.Business.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Linq.Expressions;

namespace Business.Concrete
{
	public class CommentManager : EntityManager<Comment>, ICommentService
	{
		private readonly ICommentRepository _commentRepository;
        public CommentManager(ICommentRepository commentRepository) : base(commentRepository)
        {
			_commentRepository = commentRepository;
        }

		public List<Comment> ArticleCommentsWithUser(int id)
		{
			return _commentRepository.ArticleCommentsWithUser(id);
		}
	}
}
