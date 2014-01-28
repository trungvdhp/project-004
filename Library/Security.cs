using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Library
{

    public class Security
    {
        /// <summary>
        /// Mã hóa SHA
        /// </summary>
        /// <param name="data">Chuỗi cần mã hóa</param>
        /// <returns>Chuỗi đã được mã hóa</returns>
        public static string CreateSHAHash(string data)
        {
            SHA512Managed HashTool = new SHA512Managed();
            Byte[] PhraseAsByte = Encoding.UTF8.GetBytes(string.Concat(data));
            Byte[] EncryptedBytes = HashTool.ComputeHash(PhraseAsByte);
            HashTool.Clear();
            return Convert.ToBase64String(EncryptedBytes);
        }

        /// <summary>
        /// Mã hóa MD5
        /// </summary>
        /// <param name="message">Chuỗi cần mã hóa</param>
        /// <param name="key">Khóa mã hóa</param>
        /// <returns>Chuỗi đã được mã hóa</returns>
        public static string EnCryptMD5(string message, string key)
        {
            byte[] results;
            UTF8Encoding utf8 = new UTF8Encoding();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] deskey = md5.ComputeHash(utf8.GetBytes(key));
            TripleDESCryptoServiceProvider desalg = new TripleDESCryptoServiceProvider
            {
                Key = deskey,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7,
            };

            try
            {
                byte[] encryptData = utf8.GetBytes(message);
                ICryptoTransform encryptor = desalg.CreateEncryptor();
                results = encryptor.TransformFinalBlock(encryptData, 0, encryptData.Length);
            }
            finally
            {
                desalg.Clear();
                md5.Clear();
            }
            return Convert.ToBase64String(results);
        }

        /// <summary>
        /// Giải mã MD5
        /// </summary>
        /// <param name="message">Chuỗi cần giải mã</param>
        /// <param name="key">Khóa giải mã</param>
        /// <returns>Chuỗi đã được giải mã</returns>
        public static string DeCryptMD5(string message, string key)
        {
            byte[] results;
            UTF8Encoding utf8 = new UTF8Encoding();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] deskey = md5.ComputeHash(utf8.GetBytes(key));
            TripleDESCryptoServiceProvider desalg = new TripleDESCryptoServiceProvider()
            {
                Key = deskey,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7,
            };

            try
            {
                byte[] decrypt_data = Convert.FromBase64String(message);
                ICryptoTransform decryptor = desalg.CreateDecryptor();
                results = decryptor.TransformFinalBlock(decrypt_data, 0, decrypt_data.Length);

            }
            finally
            {
                desalg.Clear();
                md5.Clear();
            }
            
            return utf8.GetString(results);
        }
    }
}
