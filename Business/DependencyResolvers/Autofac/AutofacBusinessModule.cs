using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*DependencyResolvers klasörü, bir uygulamanın bağımlılıklarını
 * yöneten modüllerin bulunduğu bir klasördür. Autofac altındaki
 * AutofacBusinessModule, bu klasör içindeki bağımlılıkları çözen bir Autofac modülüdür.*/
namespace Business.DependencyResolvers.Autofac
{
     public  class AutofacBusinessModule:Module
    {
        /// Bağımlılıkları çözen Autofac modülü.

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

           // builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();

            //Autofac bize .Net mimarisi disinda Interceptor görevi kazandiriyor. Yukaridaki tün siniflari tariyor, bu class'larin Aspect'i var mi diye tariyor.
            //Asagidaki kod blogu ile calisan uygulama icerisinde implemente edilmis interface'leri bul
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector() //onlar icin AspectInterceptorSelector cagir diyoruz
                }).SingleInstance();
        }
    }
}
   
