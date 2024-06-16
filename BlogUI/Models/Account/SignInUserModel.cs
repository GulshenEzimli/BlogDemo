using BlogUI.Models.Interfaces;

namespace BlogUI.Models.Account
{
    public class SignInUserModel : IControlModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool CheckMeOut { get; set; }
    }
}
