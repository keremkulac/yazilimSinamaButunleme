using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace yazilimSinamaButunleme
{
    public class DES
    {
        
        public string EncryptionDES(string strText,string strKey)
        {
            byte[] bykey = { };
            byte[] iv = {0x01,0x06, 0x06, 0x02, 0x09, 0x06, 0x02, 0x07 };
            try
            {
                bykey = Encoding.UTF8.GetBytes(strKey);
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();  
                byte[] input = Encoding.UTF8.GetBytes(strText); 
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(bykey, iv),CryptoStreamMode.Write);
                cs.Write(input, 0, input.Length);
                cs.FlushFinalBlock();   
                return Convert.ToBase64String(ms.ToArray());    

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string DecryptionDES(string strText,string strKey)
        {
            byte[] bykey = { };
            byte[] iv = { 0x01, 0x06, 0x06, 0x02, 0x09, 0x06, 0x02, 0x07 };
            byte[] input = new byte[strText.Length];
            try
            {
                bykey = Encoding.UTF8.GetBytes(strKey);
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                input = Convert.FromBase64String(strText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(bykey, iv), CryptoStreamMode.Write);
                cs.Write(input, 0, input.Length);
                cs.FlushFinalBlock();
                Encoding en = Encoding.UTF8;
                return en.GetString(ms.ToArray());

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
