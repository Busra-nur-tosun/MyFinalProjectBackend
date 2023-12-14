using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Castle.DynamicProxy;

/*
Interceptors (AOP - Aspect-Oriented Programming) klasörü, uygulamada kullanılacak
olan aspect'leri (yani, loglama, hata yönetimi, önbellekleme gibi modüler işlevleri) 
tanımlayan sınıfları içeren bir klasördür. Bu sınıflar, iş mantığı kodlarına entegre edilmeden önce,
ilgili metodların öncesine veya sonrasına ek işlemler eklemek üzere tasarlanmıştır.

İnterceptor sınıfları, genellikle MethodInterceptionBaseAttribute sınıfından türemiş özel nitelikler içerir. 
Bu nitelikler, belirli bir metodun önünde veya sonunda çalışacak kodları tanımlar. Örneğin, bir loglama işlemi 
gerçekleştiren bir LogAspect sınıfı, MethodInterceptionBaseAttribute'dan türemiş olabilir ve bir metodun 
başında veya sonunda loglama kodlarını içerebilir.*/
namespace Core.Utilities.Interceptors
{
    /// Aspect'leri seçen ve sıralayan sınıf.

    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);

            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }

}