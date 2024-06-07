using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
	public class NewsLetterRepository : EfEntityRepository<NewsLetter>, INewsLetterRepository
	{
        private readonly DbContext _dbContext;

		public NewsLetterRepository(DbContext dbContext): base(dbContext)	
		{
			_dbContext = dbContext;
		}
	}
}
