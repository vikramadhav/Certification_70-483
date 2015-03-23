using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3.Objective2
{
    [Listing("RSA public/private key")]
    public class Listing_3_18 : IRunnable
    {
        public void Run()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            string publicKeyXML = rsa.ToXmlString(false);
            string privateKeyXML = rsa.ToXmlString(true);

            Console.WriteLine(publicKeyXML);
            Console.WriteLine(privateKeyXML);
        }
    }
}
