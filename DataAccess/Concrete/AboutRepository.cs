using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.DbContexts;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
	public class AboutRepository : EfEntityRepository<BlogDbContext, About>, IAboutRepository
	{
	}
}
