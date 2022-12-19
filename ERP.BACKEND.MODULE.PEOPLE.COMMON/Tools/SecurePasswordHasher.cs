namespace ERP.BACKEND.MODULE.PERSON.COMMON.Tools
{
    using System.Security.Cryptography;
    using System.Text;

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

        public static bool CompareHash(string password, string hashedPassword) => (Hash(password).Equals(hashedPassword));
    }
}
