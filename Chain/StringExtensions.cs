using System;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace Chain
{
    public class StringExtensions
    {
        public static string ApplySha256(string input)
        {
            var hashAlgorithm = HashAlgorithm.Create("SHA256");
            var crypto = hashAlgorithm.ComputeHash(Encoding.ASCII.GetBytes(input));

            var hash = new StringBuilder();

            foreach (var b in crypto)
            {
                hash.Append(b.ToString("x2"));
            }

            return hash.ToString();
        }
    }
}