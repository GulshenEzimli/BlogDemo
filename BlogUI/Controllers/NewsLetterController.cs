using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	public class NewsLetterController : Controller
	{
		[HttpPost]
		public IActionResult SubscribeMail(string mail)
		{
			return View();
		}
	}
}
