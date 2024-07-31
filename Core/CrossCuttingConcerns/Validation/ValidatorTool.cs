using Core.Entity.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using FluentValidation;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidatorTool
    {
        public static IResult Validate<T>(T entity, IValidator<T> validator) where T : class,IEntity, new()
        {
            var result = new Result(true, "Entity is valid");

            var context = new ValidationContext<T>(entity);
            var validationResult = validator.Validate(context);
            
            if(!validationResult.IsValid)
            {
                result = new Result(false, "Entity is not valid");
            }

            return result;
        }

    }
}
