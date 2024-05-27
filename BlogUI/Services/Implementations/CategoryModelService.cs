using BlogUI.Mappers.Interfaces;
using BlogUI.Models.Category;
using BlogUI.Services.Interfaces;
using Business.Abstract;
using Entity.Concrete;
using System.Linq.Expressions;

namespace BlogUI.Services.Implementations
{
	public class CategoryModelService : ICategoryModelService
	{
		private readonly ICategoryMapper _mapper;
		private readonly ICategoryService _service;
		public CategoryModelService(ICategoryMapper mapper, ICategoryService service)
		{
			_mapper = mapper;
			_service = service;
		}

		public CategoryModel GetById(int id)
		{
			var category = _service.GetById(c => c.Id==id);
			var model = _mapper.Map(category);
			return model;
		}

		public List<CategoryModel> GetAll()
		{
			var categories = _service.GetAll();
			var models = new List<CategoryModel>();
			foreach (var category in categories)
			{
				var categoryModel = _mapper.Map(category);
				models.Add(categoryModel);
			}
			return models;
		}

		public void Add(CategoryModel model)
		{
			var category = _mapper.Map(model);
			_service.Add(category);
		}

		public void Delete(int id)
		{
			_service.Delete(id);
		}

		public void Update(CategoryModel model)
		{
			var category = _mapper.Map(model);
			_service.Update(category);
		}
	}
}
