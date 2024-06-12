using BlogUI.Mappers.Interfaces;
using BlogUI.Models.About;
using BlogUI.Services.Interfaces;
using Business.Abstract;
using Entity.Concrete;

namespace BlogUI.Services.Implementations
{
    public class AboutModelService : ControlModelService<About, AboutModel>, IAboutModelService
    {
        private readonly IAboutMapper _aboutMapper;
        private readonly IAboutService _aboutService;

        public AboutModelService(IAboutMapper aboutMapper,IAboutService aboutService) : base(aboutMapper, aboutService)
        {
            _aboutService = aboutService;
        }
    }
}
