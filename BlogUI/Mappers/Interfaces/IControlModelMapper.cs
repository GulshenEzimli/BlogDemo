using BlogUI.Models.Interfaces;
using Core.Entity.Abstract;

namespace BlogUI.Mappers.Interfaces
{
	public interface IControlModelMapper<TEntity,TModel> where TEntity : class,IEntity, new()
														 where TModel : class, IControlModel, new()
	{
		TEntity Map(TModel model);
		TModel Map(TEntity entity);
	}
}
