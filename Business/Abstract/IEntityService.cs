using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEntityService<T> where T : class,IEntity,new()
    {
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
		List<T> GetAll();
		T GetById(Expression<Func<T,bool>> filter);
    }
}
