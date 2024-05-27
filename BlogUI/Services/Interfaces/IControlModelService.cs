using BlogUI.Models.Interfaces;
using System.Linq.Expressions;

namespace BlogUI.Services.Interfaces
{
	public interface IControlModelService<TModel> where TModel : class, IControlModel, new()
	{
		TModel GetById(int id);
		List<TModel> GetAll();
		void Add(TModel model);
		void Delete(int id);
		void Update(TModel model);
	}
}
