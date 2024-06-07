using BlogUI.Models.NewsLetter;
using BlogUI.Services.Interfaces;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.Controllers
{
	public class NewsLetterController : Controller
	{
		private readonly INewsLetterModelService _service;

		public NewsLetterController(INewsLetterModelService service)
		{
			_service = service;
		}

		[HttpPost]
		public IActionResult SubscribeMail(NewsLetterModel model, int id)
		{
			//var newsLetterModel = new NewsLetterModel();
			//newsLetterModel.Mail = mail;
			//newsLetterModel.IsDeleted = false;
			//_service.Add(newsLetterModel);

			return RedirectToAction();
		}
	}
}
