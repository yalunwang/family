using System;
using System.Text;
using System.Security.Cryptography;
using System.Web.Security;

namespace ZKEShop.SystemFramework
{
   public class _MD5
    {

       private const string strkey = "zhang-Yan.world";//加密解密密钥

        public byte[] getbyte(string str)
        {
            return Encoding.Default.GetBytes(str);
        }

        ///md5加密解密
        ///<param name="strkey">密钥不限定位数</param>   
        public string md5Encrypt(String plainText)
        {
            if (plainText.Trim() == "") return "";
            string encrypted = null;
            byte[] key = getbyte(strkey);
            try
            {
                byte[] inputBytes = ASCIIEncoding.ASCII.GetBytes(plainText);
                byte[] pwdhash = null;
                MD5CryptoServiceProvider hashmd5;
                //generate   an   MD5   hash   from   the   password.     
                //a   hash   is   a   one   way   encryption   meaning   once   you   generate   
                //the   hash,   you   cant   derive   the   password   back   from   it.   
                hashmd5 = new MD5CryptoServiceProvider();
                pwdhash = hashmd5.ComputeHash(key);
                hashmd5 = null;
                //   Create   a   new   TripleDES   service   provider     
                TripleDESCryptoServiceProvider tdesProvider = new TripleDESCryptoServiceProvider();
                tdesProvider.Key = pwdhash;
                tdesProvider.Mode = CipherMode.ECB;

                encrypted = Convert.ToBase64String(tdesProvider.CreateEncryptor().TransformFinalBlock(inputBytes, 0, inputBytes.Length));
            }
            catch (Exception e)
            {
                string str = e.Message;
                throw;
            }
            return encrypted;
        }

        ///   <summary>   
        ///   md5解密   
        ///   </summary>   
        ///   <param   name="encryptedString"></param>   
        ///   <param   name="strkey">密钥</param>   
        ///   <returns></returns>   
        public string md5Decrypt(string encryptedString)
        {
            if (encryptedString.Trim() == "") return "";
            string decyprted = null;
            byte[] inputBytes = null;
            byte[] key = getbyte(strkey);
            try
            {
                inputBytes = Convert.FromBase64String(encryptedString);
                byte[] pwdhash = null;
                MD5CryptoServiceProvider hashmd5;
                //generate   an   MD5   hash   from   the   password.     
                //a   hash   is   a   one   way   encryption   meaning   once   you   generate   
                //the   hash,   you   cant   derive   the   password   back   from   it.   
                hashmd5 = new MD5CryptoServiceProvider();
                pwdhash = hashmd5.ComputeHash(key);
                hashmd5 = null;
                //   Create   a   new   TripleDES   service   provider     
                TripleDESCryptoServiceProvider tdesProvider = new TripleDESCryptoServiceProvider();
                tdesProvider.Key = pwdhash;
                tdesProvider.Mode = CipherMode.ECB;
                decyprted = ASCIIEncoding.ASCII.GetString(tdesProvider.CreateDecryptor().TransformFinalBlock(inputBytes, 0, inputBytes.Length));
            }
            catch (Exception e)
            {
                string str = e.Message;
                throw;
            }
            return decyprted;
        }
        ///   <summary>   
        ///   md5加密   
        ///   </summary>   
        ///   <param   name="source"></param>   
        ///   <returns></returns>   
        public string md5Encrypt(string source,int code)
        {
            //作为密码方式加密
            string _md5Str=string.Empty;
            switch (code)
            {
                case 16:
                    _md5Str = FormsAuthentication.HashPasswordForStoringInConfigFile(source, "MD5").Substring(8, 16); break;
                case 32:
                    _md5Str = FormsAuthentication.HashPasswordForStoringInConfigFile(source, "MD5"); break;
            }
            return _md5Str.ToLower();
        }

       /// <summary>
       /// md5加密
       /// </summary>
       /// <param name="str"></param>
       /// <returns></returns>
        public string MD5pwd(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.Default.GetBytes(str);
            byte[] result = md5.ComputeHash(data);
            string returnVal = "";
            for (int i = 0; i < result.Length; i++)
            {
                returnVal += result[i].ToString("x").PadLeft(2, '0');
            }
            return returnVal;
        }
    }
}
