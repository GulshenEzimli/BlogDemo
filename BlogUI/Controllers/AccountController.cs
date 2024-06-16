using BlogUI.Models.Account;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlogUI.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult SignIn(string returnUrl)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInUserModel user)
        {
            //HttpContext.Session.SetString("UserName", user.Email);
            //login actions
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Email, user.Email),
            };
            var userIdentity = new ClaimsIdentity(claims);
            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync(principal);
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpUserModel user)
        {
            return View();
        }
    }
}
