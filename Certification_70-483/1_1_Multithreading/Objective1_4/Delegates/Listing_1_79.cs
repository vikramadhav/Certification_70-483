using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_4.Delegates
{
    public class Listing_1_79 : IRunnable
    {
        public delegate int Calculate(int x, int y);

        public void Run()
        {
            Calculate calc = (x, y) => x + y;
            Console.WriteLine(calc(3, 4)); // Displays 7
            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4)); // Displays 12

            calc =
(x, y) =>
{
    Console.WriteLine("Adding numbers");
    return x + y;
};
           Console.WriteLine(calc(3, 4));
        }
    }
}
