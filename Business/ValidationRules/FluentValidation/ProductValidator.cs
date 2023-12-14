using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
   /* ValidationRules klasörü genellikle FluentValidation veya başka bir doğrulama 
    * kütüphanesini kullanarak uygulama seviyesinde kuralları içeren sınıfları barındırır.
    * Bu klasördeki sınıflar, veri girişlerini doğrulamak ve iş kurallarını uygulamak için kullanılır.*/
    public class ProductValidator : AbstractValidator<Product>
    { /// Product sınıfı için doğrulama kurallarını içeren sınıf.

        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
      
        }

    }
}
