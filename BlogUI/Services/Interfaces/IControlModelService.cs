using BlogUI.Models.Interfaces;
using Core.Entity.Abstract;
using System.Linq.Expressions;

namespace BlogUI.Services.Interfaces
{
	public interface IControlModelService<TEntity,TModel> where TModel : class, IControlModel, new()
                                                          where TEntity : class, IEntity, new()
    {
		TModel GetById(Expression<Func<TEntity,bool>> filter);
		List<TModel> GetAll();
		void Add(TModel model);
		void Delete(int id);
		void Update(TModel model);
	}
}
