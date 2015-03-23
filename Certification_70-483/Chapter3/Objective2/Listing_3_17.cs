using Certification.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3.Objective2
{
    [Listing("Symetric encryption")]
    public class Listing_3_17 : IRunnable
    {
        public void Run()
        {
            string original = "My secret data!";
            using (SymmetricAlgorithm symmetricAlgorithm =
            new AesManaged())
            {
                byte[] encrypted = Encrypt(symmetricAlgorithm, original);
                string roundtrip = Decrypt(symmetricAlgorithm, encrypted);
                // Displays: My secret data!
                Console.WriteLine("Original: {0}", original);
                Console.WriteLine("Round Trip: {0}", roundtrip);
            }
        }

        static byte[] Encrypt(SymmetricAlgorithm aesAlg, string plainText)
        {
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt =
                new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                    return msEncrypt.ToArray();
                }
            }
        }
        static string Decrypt(SymmetricAlgorithm aesAlg, byte[] cipherText)
        {
            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
            using (MemoryStream msDecrypt = new MemoryStream(cipherText))
            {
                using (CryptoStream csDecrypt =
                new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
    }
}
