using Core.Aspects.Autofac.Validation;
using Core.Business.Abstract;
using Core.DataAccess.Abstract;
using Core.Entity.Abstract;
using FluentValidation;
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

        //[ValidationAspect(aspectType)]
		public void Add(TEntity entity)
		{
			_repository.Add(entity);
		}

		public void Delete(TEntity entity)
		{
			_repository.Delete(entity);
		}

		public void Update(TEntity entity)
		{
			_repository.Update(entity);
		}

		public List<TEntity> GetAll()
		{
			return _repository.GetAll();
		}

		public TEntity Get(Expression<Func<TEntity, bool>> filter)
		{
			return _repository.Get(filter);
		}
	}
}
