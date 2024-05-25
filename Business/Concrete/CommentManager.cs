using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class CommentManager : EntityManager<Comment>
	{
        public CommentManager(ICommentRepository commentRepository) : base(commentRepository)
        {
        }
    }
}
