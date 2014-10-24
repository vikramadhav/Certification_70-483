using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace EncryptionSamples.Symmetric
{
    public class AesManagedSample
    {
        private const int Iterations = 100;
            
        private static byte[] Encrypt(string value, string password, string salt)
        {
            DeriveBytes rgb = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt), Iterations);

            SymmetricAlgorithm algorithm = new AesManaged();

            byte[] rgbKey = rgb.GetBytes(algorithm.KeySize / 8);
            byte[] rgbIV = rgb.GetBytes(algorithm.BlockSize / 8);

            ICryptoTransform transform = algorithm.CreateEncryptor(rgbKey, rgbIV);

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
                {
                    using (var writer = new StreamWriter(cryptoStream, Encoding.Unicode))
                    {
                        writer.Write(value);
                    }
                }

                return memoryStream.ToArray();
            }
        }


        private static string Decrypt(byte[] encrypted, string password, string salt)          
        {
            DeriveBytes rgb = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt), Iterations);

            SymmetricAlgorithm algorithm = new AesManaged();

            byte[] rgbKey = rgb.GetBytes(algorithm.KeySize / 8);
            byte[] rgbIV = rgb.GetBytes(algorithm.BlockSize / 8);

            ICryptoTransform transform = algorithm.CreateDecryptor(rgbKey, rgbIV);

            using (var memoryStream = new MemoryStream(encrypted))
            {
                using (var cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
                {
                    using (var reader = new StreamReader(cryptoStream, Encoding.Unicode))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
        }

        public static void Run()
        {
            string input = "Data to be AES Encrypted!";
            var encrypted = Encrypt(input, "pass", "salt");
            var decrypted = Decrypt(encrypted, "pass", "salt");

            Console.WriteLine("Symmetric AesManaged");
            Console.WriteLine("Input:{0}", input);
            Console.WriteLine("Encrypted:{0}", Convert.ToBase64String(encrypted));
            Console.WriteLine("Decrypted:{0}", decrypted);
            Console.WriteLine();
        }
    }
}