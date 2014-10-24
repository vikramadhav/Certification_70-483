using System;
using System.Security.Cryptography;
using System.Text;

namespace EncryptionSamples.ProtectingData {
    class ProtectDataSample {

        static byte[] ProtectString(string data) {

            byte[] userData = Encoding.Default.GetBytes(data);
            byte[] encryptedData = ProtectedData.Protect(userData, null,
                                            DataProtectionScope.LocalMachine);
            return encryptedData;
        }

        static string UnprotectString(byte[] encryptedData) {

            byte[] userData = ProtectedData.Unprotect(encryptedData, null,
                                            DataProtectionScope.LocalMachine);
            string data = Encoding.Default.GetString(userData);
            return data;
        }

        public static void Run() {
            string input = "Data to be Protected!";
            
            var encrypted = ProtectString(input);
            var unprotected = UnprotectString(encrypted);

            Console.WriteLine("Using ProtectedData");
            Console.WriteLine("Input:{0}", input);
            Console.WriteLine("Protected: {0}", encrypted);
            Console.WriteLine("Unprotected: {0}", unprotected);
            Console.WriteLine();
        }

    }
}
