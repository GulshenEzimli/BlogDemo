using Core.DataAccess.Abstract;
using Core.Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Concrete.EntityFramework
{
	public class EfEntityRepository<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
	{
		private readonly DbContext _dbContext;
		public EfEntityRepository(DbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public void Add(TEntity entity)
		{
			var addedEntity = _dbContext.Entry(entity);
			addedEntity.State = EntityState.Added;
			_dbContext.SaveChanges();
		}

		public void Delete(int id)
		{
			var deletedEntity = _dbContext.Entry(id);
			deletedEntity.State = EntityState.Deleted;
			_dbContext.SaveChanges();
		}

		public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
		{
			return filter == null ? _dbContext.Set<TEntity>().ToList() :
									_dbContext.Set<TEntity>().Where(filter).ToList();
		}

		public TEntity GetById(Expression<Func<TEntity, bool>> filter)
		{
			return _dbContext.Set<TEntity>().LastOrDefault(filter);
		}

		public void Update(TEntity entity)
		{
			var updatedEntity = _dbContext.Entry(entity);
			updatedEntity.State = EntityState.Modified;
			_dbContext.SaveChanges();
		}
	}
}
