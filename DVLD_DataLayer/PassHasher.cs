using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DVLD_DataLayer
{
    public class PassHasher
    {
        public static string Hash256(string pass)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pass));

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}
