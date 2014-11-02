using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_2.Synchronization
{
    public class Listing_1_40 : IRunnable
    {
        public void Run()
        {
            int n = 0;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    Interlocked.Increment(ref n);
            });
            for (int i = 0; i < 1000000; i++)
                Interlocked.Decrement(ref n);
            up.Wait();
            Console.WriteLine(n);
        }
    }
}
