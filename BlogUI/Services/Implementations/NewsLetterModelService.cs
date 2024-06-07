using BlogUI.Mappers.Interfaces;
using BlogUI.Models.NewsLetter;
using BlogUI.Services.Interfaces;
using Business.Abstract;
using Entity.Concrete;

namespace BlogUI.Services.Implementations
{
    public class NewsLetterModelService : ControlModelService<NewsLetter,NewsLetterModel>,INewsLetterModelService
    {
        private readonly INewsLetterMapper _newsLetterMapper;
        private readonly INewsLetterService _newsLetterService;
        public NewsLetterModelService(INewsLetterMapper newsLetterMapper, INewsLetterService newsLetterService) : base(newsLetterMapper,newsLetterService)
        {
            _newsLetterMapper = newsLetterMapper;
            _newsLetterService = newsLetterService;
        }
    }
}
