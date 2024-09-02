using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors
{
    public class MethodInterception : MethodInterceptorBaseAttribute
    {
        public virtual void OnAfter(IInvocation invocation) { }
        public virtual void OnBefore(IInvocation invocation) { }
        public virtual void OnException(IInvocation invocation, Exception exception) { }
        public virtual void OnSuccess(IInvocation invocation) { }

        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation);

            try
            {
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                isSuccess = false;
                OnException(invocation, ex);
                throw;
            }
            finally 
            {
                if(isSuccess)
                    OnSuccess(invocation);    
            }

            OnAfter(invocation);
        }
    }
}
