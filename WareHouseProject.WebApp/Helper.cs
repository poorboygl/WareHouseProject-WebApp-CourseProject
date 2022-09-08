using System;
using System.Collections.Generic;

using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp
{
    public class Helper
    {
        public static byte[] Sha(string plantext)
        {
            HashAlgorithm hash = HashAlgorithm.Create("SHA512");
            return hash.ComputeHash(Encoding.ASCII.GetBytes(plantext));
        }
        public static string RandomString(int n)
        {
            string s = "qwertyuiopasdfghjklzxcvbnm1234567890";
            char[] a = new Char[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = s[random.Next(s.Length)];
            }
            return string.Join("", a);
        }
    }
}
