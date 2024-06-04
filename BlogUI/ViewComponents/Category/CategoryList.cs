using BlogUI.Models.Category;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogUI.ViewComponents.Category
{
	public class CategoryList : ViewComponent
	{
		private readonly ICategoryService _categoryService;
		private readonly IArticleService _articleService;
		public CategoryList(ICategoryService categoryService, IArticleService articleService)
		{
			_categoryService = categoryService;
			_articleService = articleService;
		}

		public IViewComponentResult Invoke()
		{
			var categories = _categoryService.GetAll().Select(c => new CategoryCountsModel
			{
				Id = c.Id,
				Name = c.Name,
				Count = _articleService.GetAll().Where(a => a.CategoryId == c.Id).ToList().Count	
			}).ToList();
			return View(categories);
		}
	}
}
