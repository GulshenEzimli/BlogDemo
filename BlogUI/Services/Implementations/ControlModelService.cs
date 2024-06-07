using BlogUI.Mappers.Interfaces;
using BlogUI.Models.Interfaces;
using BlogUI.Services.Interfaces;
using Core.Business.Abstract;
using Core.Entity.Abstract;
using System.Linq.Expressions;

namespace BlogUI.Services.Implementations
{
    public class ControlModelService<TEntity, TModel> : IControlModelService<TEntity,TModel> where TEntity : class,IEntity, new()
                                                                                     where TModel : class,IControlModel,new()
    {
        private readonly IControlModelMapper<TEntity, TModel> _mapper;
        private readonly IEntityService<TEntity> _entityBusinessService;
        public ControlModelService(IControlModelMapper<TEntity, TModel> mapper, IEntityService<TEntity> entityBusinessService)
        {
            _mapper = mapper;
            _entityBusinessService = entityBusinessService;
        }

        public TModel GetById(Expression<Func<TEntity, bool>> filter)
        {
            var entity = _entityBusinessService.GetById(filter);
            var model = _mapper.Map(entity);

            return model;
        }

        public List<TModel> GetAll()
        {
            var entities = _entityBusinessService.GetAll();
            var models = new List<TModel>();
            foreach (var entity in entities)
            {
                var model = _mapper.Map(entity);
                models.Add(model);
            }
            return models;
        }

        public void Add(TModel model)
        {
            var entity = _mapper.Map(model);
            _entityBusinessService.Add(entity);
        }

        public void Delete(int id)
        {
            _entityBusinessService.Delete(id);
        }

        public void Update(TModel model)
        {
            var entity = _mapper.Map(model);
            _entityBusinessService.Update(entity);
        }
    }
}
