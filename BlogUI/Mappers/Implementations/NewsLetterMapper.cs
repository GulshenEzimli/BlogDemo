using BlogUI.Mappers.Interfaces;
using BlogUI.Models.NewsLetter;
using Entity.Concrete;

namespace BlogUI.Mappers.Implementations
{
    public class NewsLetterMapper : INewsLetterMapper
    {
        public NewsLetter Map(NewsLetterModel model)
        {
            var entity = new NewsLetter();
            entity.Mail = model.Mail;
            entity.IsDeleted = model.IsDeleted;

            return entity;
        }

        public NewsLetterModel Map(NewsLetter entity)
        {
            var model = new NewsLetterModel();
            model.Mail = entity.Mail;
            model.IsDeleted = entity.IsDeleted;
            model.Id = entity.Id;

            return model;
        }
    }
}
