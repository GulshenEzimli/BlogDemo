using Business.Abstract;
using Core.Business.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;


namespace Business.Concrete
{
	public class CategoryManager : EntityManager<Category>, ICategoryService
	{
        public CategoryManager(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
        }
    }
}
