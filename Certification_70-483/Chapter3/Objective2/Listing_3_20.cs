using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3.Objective2
{
    [Listing("Key container")]
    public class Listing_3_20 : IRunnable
    {
        public void Run()
        {
            string containerName = "SecretContainer";

            //CspParameters csp = new CspParameters() { KeyContainerName = containerName };
            //RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(csp);


            CspParameters csp1 = new CspParameters() { KeyContainerName = containerName };
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes("My Secret Data!");
            byte[] encryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp1))
            {
                encryptedData = RSA.Encrypt(dataToEncrypt, false);
            }

            byte[] decryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp1))
            {
                decryptedData = RSA.Decrypt(encryptedData, false);
            }
            string decryptedString = ByteConverter.GetString(decryptedData);
            Console.WriteLine(decryptedString); // Displays: My Secret Data! 
        }
    }
}
