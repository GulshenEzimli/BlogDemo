using Business.Abstract;
using Core.Business.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
	public class ContactManager : EntityManager<Contact>, IContactService
	{
        public ContactManager(IContactRepository contactRepository) : base(contactRepository)
        {
        }
    }
}
