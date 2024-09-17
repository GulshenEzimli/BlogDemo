using BlogUI.Mappers.Interfaces;
using BlogUI.Models.Category;
using Entity.Concrete;

namespace BlogUI.Mappers.Implementations
{
	public class CategoryMapper : ICategoryMapper
	{
		public Category Map(CategoryModel model)
		{
			Category category = new Category();

			category.Id = model.Id;
			category.Name = model.Name;
			category.Description = model.Description;

			return category;
		}

		public CategoryModel Map(Category entity)
		{
			CategoryModel model = new CategoryModel();
            model.UniqueId = entity.UniqueId;
			model.Id = entity.Id;
			model.Name = entity.Name;
			model.Description = entity.Description;

			return model;
		}
	}
}
