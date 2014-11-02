using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_2.Synchronization
{
    public class Listing_1_35 : IRunnable
    {
        public void Run()
        {
            int n = 0;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    n++;
            });
            for (int i = 0; i < 1000000; i++)
                n--;
            up.Wait();
            Console.WriteLine(n);
        }
    }
}
