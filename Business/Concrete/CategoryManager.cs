using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class CategoryManager : EntityManager<Category>
	{
        public CategoryManager(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
        }
    }
}
