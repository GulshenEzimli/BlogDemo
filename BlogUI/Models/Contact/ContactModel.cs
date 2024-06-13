using BlogUI.Models.Interfaces;
using Entity.Concrete;

namespace BlogUI.Models.Contact
{
    public class ContactModel : IControlModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
