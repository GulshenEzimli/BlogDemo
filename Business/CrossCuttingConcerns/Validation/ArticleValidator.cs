using Entity.Concrete;
using FluentValidation;

namespace Business.CrossCuttingConcerns.Validation
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            
        }
    }
}
