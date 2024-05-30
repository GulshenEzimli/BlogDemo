using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.DbContexts;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
	public class CategoryRepository : EfEntityRepository<Category>, ICategoryRepository
	{
		private readonly DbContext _dbContext;

		public CategoryRepository(DbContext dbContext) : base(dbContext)
		{
			_dbContext = dbContext;
		}
	}
}
