using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{// Bu sınıf, bir hata durumunun sonucunu temsil eden ve sadece başarısız durumu içeren bir nesnedir.

    public class ErrorResult:Result
    {
        public ErrorResult(string message):base (false,message)
        {

        }
        public ErrorResult():base(false)
        {

        }
    }
}
