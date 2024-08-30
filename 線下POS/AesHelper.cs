using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace 線下POS
{
    class AesHelper
    {
        public string AesClientCertId { get; set; } = "23220";
        public string AesKey { get; set; } = "3AskpLvNR0lBoMHftSisYBTUeENPJz2m";
        public string AesIv { get; set; } = "H42BAEv8HA37Wn1i";



        public string EncKeyID { get; set; } = "23220";
        public string AES_Key { get; set; } = "3AskpLvNR0lBoMHftSisYBTUeENPJz2m";
        public string AES_IV { get; set; } = "H42BAEv8HA37Wn1i";

        public string AesEncrypt(string original, string key, string iv)
        {

            key = string.IsNullOrEmpty(key) ? AesKey : key;
            iv = string.IsNullOrEmpty(iv) ? AesIv : iv;
            string encrypt = "";


            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = Encoding.UTF8.GetBytes(iv);

                // Create the streams used for encryption.
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV), CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            //Write all data to the stream.
                            sw.Write(original);
                        }

                        encrypt = Convert.ToBase64String(ms.ToArray());
                    }
                }
            }



            return encrypt;
        }

        /// <summary>
        /// AES 解密字串
        /// </summary>
        /// <param name="hexString">已加密字串</param>
        /// <param name="key">自訂金鑰</param>
        /// <param name="iv">自訂向量</param>
        /// <returns></returns>
        public string AesDecrypt(string hexString, string key = null, string iv = null)
        {
            if (hexString is null)
            {
                return "NULL";
            }

            key = string.IsNullOrEmpty(key) ? AesKey : key;
            iv = string.IsNullOrEmpty(iv) ? AesIv : iv;
            string decrypt = "";

            var encrypted = Convert.FromBase64String(hexString);

            try
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Encoding.UTF8.GetBytes(key);
                    aesAlg.IV = Encoding.UTF8.GetBytes(iv);

                    // Create a decrytor to perform the stream transform.
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    // Create the streams used for decryption.
                    using (MemoryStream ms = new MemoryStream(encrypted))
                    {
                        using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader sr = new StreamReader(cs))
                            {
                                // Read the decrypted bytes from the decrypting stream and place them in a string.
                                decrypt = sr.ReadToEnd();
                                Console.WriteLine(decrypt);
                                Console.WriteLine("74391749023");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //todo...
            }

            return decrypt;
        }

    }
}
