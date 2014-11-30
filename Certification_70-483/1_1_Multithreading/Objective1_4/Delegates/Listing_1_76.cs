using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_4.Delegates
{
    public class Listing_1_76 : IRunnable
    {
        public void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }
        public void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }

        public delegate void Del();

        public void Run()
        {
            Del d = MethodOne;
            d += MethodTwo;
            d();

            Console.WriteLine(d.GetInvocationList().GetLength(0));
        }
    }
}
