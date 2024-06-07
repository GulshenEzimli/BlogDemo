using BlogUI.Mappers.Interfaces;
using BlogUI.Models.Category;
using BlogUI.Services.Interfaces;
using Business.Abstract;
using Entity.Concrete;
using System.Linq.Expressions;

namespace BlogUI.Services.Implementations
{
	public class CategoryModelService : ControlModelService<Category,CategoryModel>, ICategoryModelService
	{
		private readonly ICategoryMapper _categoryMapper;
		private readonly ICategoryService _categoryService;
		public CategoryModelService(ICategoryMapper categoryMapper, ICategoryService categoryService) : base(categoryMapper, categoryService)
		{
			_categoryMapper = categoryMapper;
            _categoryService = categoryService;
		}

	}
}
