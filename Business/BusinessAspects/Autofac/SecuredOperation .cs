using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Business.Constants;
using Core.Extensions;

namespace Business.BusinessAspects.Autofac
{
    //BusinesAspect-Autofac
    /* AOP, bir uygulamanın çeşitli yerlerinde tekrar eden kodları ortadan kaldırmak 
     * ve farklı konulara(örneğin, güvenlik, loglama) odaklanan kodu ayrı bir katman 
     * içine almak için kullanılan bir programlama paradigmadır.Öte yandan, BusinessAspects 
     * klasörü genellikle iş katmanındaki çeşitli yönler (aspects) ve özellikler için kullanılır.
     * Autofac ise bir IoC (Inversion of Control) konteyneridir ve bu tür iş katmanındaki 
     * bağımlılıkları yönetmek, enjekte etmek için kullanılır.Bu sayede bağımlılıkların daha
     * esnek ve yönetilebilir olmasını sağlar.ServiceTool ise bağımlılıkları çözmek için kullanılan bir yardımcı sınıftır.
    */



    /// Bu sınıf, AOP (Aspect-Oriented Programming) olarak adlandırılan bir teknik ile
    /// ilgili operasyonlara güvenlik kontrolleri eklemeyi sağlar.

    public class SecuredOperation : MethodInterception
        {
            private string[] _roles;
            private IHttpContextAccessor _httpContextAccessor;

            public SecuredOperation(string roles)
            {
                _roles = roles.Split(',');
                _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
            }

            protected override void OnBefore(IInvocation invocation)
            {
                var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
                foreach (var role in _roles)
                {
                    if (roleClaims.Contains(role))
                    {
                        return;
                    }
                }
                throw new Exception(Messages.AuthorizationDenied);
            }
        }
    
}