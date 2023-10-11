using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        private List<global::Entities.Concrete.Product> data;
        private bool success;
        private string message;

        public DataResult(T data,bool success,string message):base(success,message)
        {
            Data = data;
        }
        public DataResult(T data,bool success):base(success)
        {
            Data = data;
        }

        public DataResult(List<global::Entities.Concrete.Product> data, bool success, string message)
        {
            this.data = data;
            this.success = success;
            this.message = message;
        }

        public T Data {get;}
    }
}
