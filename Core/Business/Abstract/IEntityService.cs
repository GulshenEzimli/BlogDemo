using Core.Entity.Abstract;
using System.Linq.Expressions;

namespace Core.Business.Abstract
{
	public interface IEntityService<T> where T : class, IEntity, new()
	{
		void Add(T entity);
		void Delete(T entity);
		void Update(T entity);
		List<T> GetAll();
		T Get(Expression<Func<T, bool>> filter);
	}
}
