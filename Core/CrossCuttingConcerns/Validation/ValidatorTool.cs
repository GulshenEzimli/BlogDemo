using Core.Entity.Abstract;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Results.Abstract;
using FluentValidation;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidatorTool
    {
        public static IResult Validate(object entity, IValidator validator) 
        {
            var result = new Result(true, "Entity is valid");

            var context = new ValidationContext<object>(entity);
            var validationResult = validator.Validate(context);
            
            if(!validationResult.IsValid)
            {
                result = new Result(false, "Entity is not valid");
            }

            return result;
        }

    }
}
