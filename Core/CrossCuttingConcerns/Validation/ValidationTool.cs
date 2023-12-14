using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Validation
{
    // Bu yardımcı sınıf, doğrulama işlemlerini gerçekleştirmek için kullanılır.
    // .NET Core'un dahili doğrulama mekanizmasını (ValidationContext, ValidationResult, ValidationException) kullanarak
    // belirtilen bir nesnenin doğruluğunu kontrol eder ve doğrulama sonucunu değerlendirir.

    public static class ValidationTool
        {
            public static void Validate(IValidator validator, object entity)
            {
                var context = new ValidationContext<object>(entity);
                var result = validator.Validate(context);
                if (!result.IsValid)
                {
                    throw new ValidationException(result.Errors);
                }
            }
        }
    
}
