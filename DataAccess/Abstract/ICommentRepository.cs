﻿using Core.DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
	public interface ICommentRepository : IEntityRepository<Comment>
	{
		List<Comment> ArticleCommentsWithUser(int id);
	}
}
