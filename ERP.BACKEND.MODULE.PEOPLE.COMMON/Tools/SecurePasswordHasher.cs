using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PERSON.COMMON.Tools
{
    public class SecurePasswordHasher
    {
        public static string Hash(string password)
        {
            var data = Encoding.UTF8.GetBytes(password);

            byte[] hash;

            using (SHA512 sha = SHA512.Create())
                hash = sha.ComputeHash(data);

            return Convert.ToHexString(hash);
        }

        public static bool CompareHash(string password, string hashedPassword)
        {
            return (Hash(password).Equals(hashedPassword));
        }
    }
}
