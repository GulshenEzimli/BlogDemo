using BlogUI.Mappers.Interfaces;
using BlogUI.Models.Contact;
using Entity.Concrete;

namespace BlogUI.Mappers.Implementations
{
    public class ContactMapper : IContactMapper
    {
        public Contact Map(ContactModel model)
        {
            var contact= new Contact();
            contact.Id = model.Id;
            contact.Email = model.Email;
            contact.Subject = model.Subject;
            contact.Message = model.Message;
            contact.CreatedDate = model.CreatedDate;
            contact.IsDeleted = model.IsDeleted;

            return contact;
        }

        public ContactModel Map(Contact entity)
        {
            var model = new ContactModel();
            model.Id = entity.Id;
            model.Email = entity.Email;
            model.Subject = entity.Subject;
            model.Message = entity.Message;
            model.CreatedDate = entity.CreatedDate;
            model.IsDeleted = entity.IsDeleted;

            return model;
        }
    }
}
