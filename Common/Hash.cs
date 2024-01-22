/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using System.Security.Cryptography;
using System.Text;

namespace cms.Common
{
    public static class Hash
    {
        /*
         * I'm using SHA256 for password hashing only because this is a school assignment
         * DO NOT USE SHA256 for password hashing in real life. 
         * 
         * Please, don't.
         */
        public static string Generate(string value)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(value));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public static bool Verify(string value, string valueHash)
        {
            return valueHash.Equals(Generate(value));
        }
    }
}
