using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private readonly Type _type;
        public ValidationAspect(Type type)
        {
            if (!type.IsAssignableFrom(typeof(IValidator)))
            {
                throw new Exception("This class don't implement validation class.");
            }
        }

        public override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_type);
            var entityType = _type.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(a => a.GetType() == entityType);

            foreach (var entity in entities)
            {
                ValidatorTool.Validate(entity, validator);
            }
        }
    }
}
