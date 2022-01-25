using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace yazilimSinamaButunleme
{
    public class SHA256
    {
        public string encryptionSHA256(string plainText)
        { 
            byte[] bytes = Encoding.UTF8.GetBytes(plainText);
            byte[] hash = SHA256Managed.Create().ComputeHash(bytes);

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                builder.Append(hash[i].ToString("X2"));
            }

            return builder.ToString();
        }
        //public string decryptionSHA256(string cryptedText)
        //{
        

        //    return null;
        //}
       


    }
}
