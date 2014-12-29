using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_2.Synchronization
{
    using System.Security.Cryptography.X509Certificates;

    public class Listing_1_39 : IRunnable
    {
        private static int _flag = 0;
        private static volatile int _value = 0;

        public static void Thread1()
        {
            _value = 5;
            _flag = 1;
        }

        public static void Thread2()
        {
            if (_flag == 1)
                Console.WriteLine(_value);
        }

        public void Run()
        {
        }
    }
}
