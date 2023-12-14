using System;
using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors
{

  //  Bu kod, Aspect-Oriented Programming(AOP) prensiplerine uygun olarak,
  //  bir metodu etkileyen ve modüler bir şekilde eklenip çıkarılabilen davranışları tanımlamak için kullanılan bir temel sınıftır.
   
       [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }



}