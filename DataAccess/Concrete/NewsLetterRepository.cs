using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.DbContexts;
using Entity.Concrete;

namespace DataAccess.Concrete
{
	public class NewsLetterRepository : EfEntityRepository<NewsLetter, BlogDbContext>, INewsLetterRepository
	{
      
	}
}
