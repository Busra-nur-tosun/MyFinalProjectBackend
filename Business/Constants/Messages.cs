﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


/*Constants(sabitler) klasörü, genellikle sabit değerleri 
 * (constant values) içeren sınıfları barındıran bir klasördür. 
 * Bu tür sabit değerler genellikle bir uygulama boyunca değişmeyen veya nadiren değişen değerlerdir.*/
namespace Business.Constants
{
    public static class Messages
    {
        //Magic Strings
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductUptaded = "Ürün güncellendi";
        public static string ProductNameInvalid = "Ürün ismi gecersiz";
        public static string MaintenanceTime = "Sistem bakimda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla {0} olabilir!";
        public static string ProductNameAlreadyExists = "Ayni ürün adina sahip baska bir ürün var!";

        public static string CategoryLimitExceded = "Kategori limiti asildigi icin yeni ürün eklenemiyor!";

        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string EmailAlreadyExist = "Bu maile ait bir kullanici daha önce kayit edilmistir!";
        public static string UserAdded = "Kullanici eklendi";
        public static string UserRegistrationSuccess = "Kullanici kaydi basari ile gerceklestirilmistir";
        public static string UserNotFound = "Kullanici bulunamadi";
        public static string PasswordIsWrong = "Parola Hatasi";
        public static string LoginIsSuccessfully = "Giris Basarili";
        public static string UserAlreadyExist = "Kullanici mevcut";
        public static string TokenCreatedSuccessfully = "Token basarili sekilde olusturuldu";

    }
}
