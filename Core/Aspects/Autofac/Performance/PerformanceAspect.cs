using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

/*Performance klasörü, uygulama seviyesinde performans ile ilgili aspect'leri 
 * içeren bir klasördür. Performans ile ilgili aspect'ler, uygulama içindeki
 * belirli metodların performansını ölçmek veya izlemek için kullanılır.

*/
namespace Core.Aspects.Autofac.Performance
{/// Belirli bir metodu çağırdıktan sonra geçen süreyi kontrol ederek belirli
    //bir eşik değerini aşan durumları tespit etmek için kullanılan bir aspect sınıfı.

    public class PerformanceAspect : MethodInterception
    {
        private int _interval;
        private Stopwatch _stopwatch;

        public PerformanceAspect(int interval)
        {
            _interval = interval;
            _stopwatch = ServiceTool.ServiceProvider.GetService<Stopwatch>();
        }


        protected override void OnBefore(IInvocation invocation)
        {
            _stopwatch.Start();
        }

        protected override void OnAfter(IInvocation invocation)
        {
            if (_stopwatch.Elapsed.TotalSeconds > _interval)
            {
                Debug.WriteLine($"Performance : {invocation.Method.DeclaringType.FullName}.{invocation.Method.Name}-->{_stopwatch.Elapsed.TotalSeconds}");
            }
            _stopwatch.Reset();
        }
    }
}