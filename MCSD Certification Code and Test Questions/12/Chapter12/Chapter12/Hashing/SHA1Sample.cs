using System;
using System.Security.Cryptography;
using System.Text;

namespace EncryptionSamples.Hashing {
    public class SHASample {
        static string ComputeHash(string input) {
            HashAlgorithm sha = SHA256.Create();
            byte[] hashData = sha.ComputeHash(Encoding.Default.GetBytes(input));
            return Convert.ToBase64String(hashData);
        }
        static bool VerifyHash(string input, string hashValue) {

            HashAlgorithm sha = SHA256.Create();
            byte[] hashData = sha.ComputeHash(Encoding.Default.GetBytes(input));
            return Convert.ToBase64String(hashData) == hashValue;
        }


        public static void Run() {

            string input = "Data to be hashed!";
            string hash = ComputeHash(input);
            bool sameHash = VerifyHash(input, hash);

            Console.WriteLine("Hashing");
            Console.WriteLine("Input:{0}", input);
            Console.WriteLine("Hash: {0}", hash);
            Console.WriteLine("Same hash: {0}", sameHash);
            Console.WriteLine();
        }

    }
}