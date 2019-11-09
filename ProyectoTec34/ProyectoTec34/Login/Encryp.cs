using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTec34.Login
{
    class Encryp
    {
        public static string EncodePassword(string originalPassword)
        {
            string clave = "7f905Wl,q8SLIQz8i|8ag¬s13Xyno/";
            SHA512 sha512 = new SHA512CryptoServiceProvider();
            byte[] inputBytes = (new UnicodeEncoding()).GetBytes(originalPassword + clave);
            byte[] hash = sha512.ComputeHash(inputBytes);
            return Convert.ToBase64String(hash);
        }
    }
}
