using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
      public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string  MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler listelendi";

        public static string ProductNameAlreadyExists = "ürün adı zaten var";
        public static string ProductCountOfCategoryError = "ürün kategori sayısı hatalı";

        public static string CategoryLimitExceded = "kategori limiti aşıldı";

        public static string AuthorizationDenied = "";

        public static User UserNotFound { get; internal set; }
        public static string UserRegistered { get; internal set; }
        public static User PasswordError { get; internal set; }
        public static string SuccessfulLogin { get; internal set; }
        public static string UserAlreadyExists { get; internal set; }
        public static string AccessTokenCreated { get; internal set; }
    }
}
