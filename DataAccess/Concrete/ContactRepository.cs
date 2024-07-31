using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.DbContexts;
using Entity.Concrete;

namespace DataAccess.Concrete
{
	public class ContactRepository : EfEntityRepository<Contact, BlogDbContext>, IContactRepository
	{

	}
}
