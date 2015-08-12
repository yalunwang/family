using System;
using System.Text;
using System.Globalization;
using System.Security.Cryptography;

namespace ZKEShop.SystemFramework
{
   public class Crypto
    {
        private static string sKey = "yanzhang";    //必须8位       
        // 加密字符串        
       public static string MD5EncryptString(string sInputString)
        {
            if (string.IsNullOrEmpty(sInputString))
                return "";

            byte[] data = Encoding.UTF8.GetBytes(sInputString);
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            byte[] result = desencrypt.TransformFinalBlock(data, 0, data.Length);
            return BitConverter.ToString(result);
        }

        // 解密字符串        
       public static string MD5DecryptString(string sInputString)
        {
            if (string.IsNullOrEmpty(sInputString))
                return "";

            try
            {
                string[] sInput = sInputString.Split("-".ToCharArray());
                byte[] data = new byte[sInput.Length];
                for (int i = 0; i < sInput.Length; i++)
                {
                    data[i] = byte.Parse(sInput[i], NumberStyles.HexNumber);
                }
                DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                ICryptoTransform desencrypt = DES.CreateDecryptor();
                byte[] result = desencrypt.TransformFinalBlock(data, 0, data.Length);
                return Encoding.UTF8.GetString(result);
            }
            catch (Exception)
            {
                return sInputString;
            }

        }
    }
}
