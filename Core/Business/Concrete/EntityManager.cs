using Core.Business.Abstract;
using Core.DataAccess.Abstract;
using Core.Entity.Abstract;
using System.Linq.Expressions;

namespace Core.Business.Concrete
{
	public class EntityManager<TEntity> : IEntityService<TEntity> where TEntity : class, IEntity, new()
	{
		private readonly IEntityRepository<TEntity> _repository;
		public EntityManager(IEntityRepository<TEntity> repository)
		{
			_repository = repository;
		}
		public void Add(TEntity entity)
		{
			_repository.Add(entity);
		}

		public void Delete(int id)
		{
			_repository.Delete(id);
		}

		public void Update(TEntity entity)
		{
			_repository.Update(entity);
		}

		public List<TEntity> GetAll()
		{
			return _repository.GetAll();
		}

		public TEntity GetById(Expression<Func<TEntity, bool>> filter)
		{
			return _repository.Get(filter);
		}
	}
}
