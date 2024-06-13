using BlogUI.Mappers.Interfaces;
using BlogUI.Models.Contact;
using BlogUI.Services.Interfaces;
using Business.Abstract;
using Entity.Concrete;

namespace BlogUI.Services.Implementations
{
    public class ContactModelService : ControlModelService<Contact, ContactModel>, IContactModelService
    {
        private readonly IContactMapper _contactMapper;
        private readonly IContactService _contactService;
        public ContactModelService(IContactMapper contactMapper, IContactService contactService) : base(contactMapper,contactService)
        {
            _contactMapper = contactMapper;
            _contactService = contactService;
        }


    }
}
