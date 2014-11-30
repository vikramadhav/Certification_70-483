using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_4.Delegates
{
    public class Listing_1_81 : IRunnable
    {
        public void Run()
        {
            Action<int, int> calc = (x, y) =>
            {
                Console.WriteLine(x + y);
            };
            calc(3, 4); // Displays 7
        }
    }
}
