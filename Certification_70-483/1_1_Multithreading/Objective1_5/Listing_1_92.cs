using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_5
{
    using Certification.Common;

    public class Listing_1_92 : IRunnable
    {
        public void Run()
        {
            string s = Console.ReadLine();
            try
            {
                int i = int.Parse(s);
                if (i == 42) Environment.FailFast("Special number entered");
            }
            finally
            {
                Console.WriteLine("Program complete.");
            }
        }
    }
}
