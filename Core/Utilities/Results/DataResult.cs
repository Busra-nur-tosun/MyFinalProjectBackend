using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{// Bu sınıf, bir işlemin sonucunu temsil eden ve aynı zamanda bir veriyi içeren bir nesnedir.

    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}