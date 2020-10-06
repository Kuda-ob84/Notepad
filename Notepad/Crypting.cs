using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    public class Crypting
    {
        static string password = "ow7dxy58glfor9tnc2ansdfoletkfjcv";

        public static byte[] EncryptString(string toEncrypt)
        {
            var key = GetKey(password);

            using (var aes = Aes.Create())
            using (var encryptor = aes.CreateEncryptor(key, key))
            {
                var plainText = Encoding.UTF8.GetBytes(toEncrypt);
                return encryptor.TransformFinalBlock(plainText, 0, plainText.Length);
            }
        }

        public static string DecryptToString(byte[] encryptedData)
        {
            var key = GetKey(password);

            using (var aes = Aes.Create())
            using (var encryptor = aes.CreateDecryptor(key, key))
            {
                var decryptedBytes = encryptor
                    .TransformFinalBlock(encryptedData, 0, encryptedData.Length);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }

        private static byte[] GetKey(string password)
        {
            var keyBytes = Encoding.UTF8.GetBytes(password);
            using (var md5 = MD5.Create())
            {
                return md5.ComputeHash(keyBytes);
            }
        }
    }
}
