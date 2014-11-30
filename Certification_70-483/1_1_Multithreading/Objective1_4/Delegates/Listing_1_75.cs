using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_4.Delegates
{
    public class Listing_1_75 : IRunnable
    {
        public delegate int Calculate(int x, int y);

        public int Add(int x, int y) { return x + y; }
        public int Multiply(int x, int y) { return x * y; }

        public void Run()
        {
            Calculate calc = Add;
            Console.WriteLine(calc(3, 4)); // Displays 7

            calc = Multiply;
            Console.WriteLine(calc(3, 4)); // Displays 12
        }
    }
}
