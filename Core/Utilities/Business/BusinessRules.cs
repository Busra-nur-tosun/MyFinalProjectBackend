using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

/*Utilities klasörü, genel işlevleri içeren yardımcı 
 * sınıfları ve araçları barındıran bir alandır. 
 * Bu klasörde yer alan BusinessRules sınıfı, genel iş kurallarını
 * değerlendirmek için kullanılan bir yardımcı sınıftır. Çeşitli modüllerde
 * veya katmanlarda kullanılabilen genel iş kurallarını tek bir yerde yönetmek 
 * ve tekrar kullanılabilir hale getirmek amacıyla bu sınıf kullanılır.*/
namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        /// Belirtilen iş kurallarını değerlendirir ve başarısız olan ilk iş kuralının sonucunu döndürür.

        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }

            return null;
        }


    }
}
