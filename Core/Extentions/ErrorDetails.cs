using FluentValidation.Results;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Core.Extensions
{
    internal class ErrorDetails
    {
        // API'de döndürülecek hata detaylarını içeren sınıf.

        public string Message { get; set; }
            public int StatusCode { get; set; }
        public IEnumerable<ValidationFailure> Errors { get; internal set; }

        public override string ToString()
            {
                return JsonConvert.SerializeObject(this);
            }
        
        public class ValidationErrorDetails:ErrorDetails
        {
            public IEnumerable<ValidationFailure> Errors { get; set; }
        }
    }
}