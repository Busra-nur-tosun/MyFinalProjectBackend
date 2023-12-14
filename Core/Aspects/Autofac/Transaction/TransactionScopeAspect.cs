using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

/*Transaction klasörü, uygulama seviyesinde transaksiyon işlemleri 
 * ile ilgili aspect'leri içeren bir klasördür. Transaksiyonlar,
 * bir grup işlemi atomik bir şekilde yönetme ihtiyacını karşılamak için kullanılır.*/
namespace Core.Aspects.Autofac.Transaction
{
    /// Bir metodun içindeki işlemleri bir TransactionScope içine alarak,
    /// bu işlemlerin atomik bir şekilde yönetilmesini sağlayan bir aspect sınıfı.

    public class TransactionScopeAspect : MethodInterception
    {
        public override void Intercept(IInvocation invocation)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    invocation.Proceed();
                    transactionScope.Complete();
                }
                catch (System.Exception e)
                {
                    transactionScope.Dispose();
                    throw;
                }
            }
        }
    }
}
