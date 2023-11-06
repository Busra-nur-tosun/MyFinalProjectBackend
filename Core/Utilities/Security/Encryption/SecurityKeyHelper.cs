using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    public class SecurityKeyHelper
    {
        //Bu class'in amaci appSettings.json dosyasina girilen SecurityKey'in projedeki ilgili yapida olusturulmasidir.
        //Ayrica SynmetricSecutiryKey ve AsyncmetricSecurityKey nedir? arastirilabilir

        //public static SecurityKey CreateSecurityKey(string securityKey) => new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
