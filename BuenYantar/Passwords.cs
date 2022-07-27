using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BuenYantar
{
    public static class Passwords
    {
        public static string test = "4d186321c1a7f0f354b297e8914ab240";
        public static string MD5(this string s)
        {
            var provider = System.Security.Cryptography.MD5.Create();
            StringBuilder builder = new StringBuilder();

            foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                builder.Append(b.ToString("x2").ToLower());

            return builder.ToString();
        }

        public static bool check(string password, string hash)
        {
            return Passwords.MD5(password).Equals(hash);
        }
    }
}
