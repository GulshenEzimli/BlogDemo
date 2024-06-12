using BlogUI.Mappers.Interfaces;
using BlogUI.Models.About;
using Entity.Concrete;

namespace BlogUI.Mappers.Implementations
{
    public class AboutMapper : IAboutMapper
    {
        public About Map(AboutModel model)
        {
            return new About
            {
                Id = model.Id,
                Details = model.Details,
                DetailsTwo = model.DetailsTwo,
                Image  = model.Image,
                ImageTwo = model.ImageTwo,
                MapLocation = model.MapLocation,
                IsDeleted = model.IsDeleted,
            };
        }

        public AboutModel Map(About entity)
        {
            return new AboutModel
            {
                Id = entity.Id,
                Details = entity.Details,
                DetailsTwo = entity.DetailsTwo,
                Image = entity.Image,
                ImageTwo = entity.ImageTwo,
                MapLocation = entity.MapLocation,
                IsDeleted = entity.IsDeleted,
            };
        }
    }
}
