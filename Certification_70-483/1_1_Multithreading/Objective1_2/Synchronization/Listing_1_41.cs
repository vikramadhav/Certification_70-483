using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_2.Synchronization
{
    public class Listing_1_41 : IRunnable
    {
        int value = 1;

        public void Run()
        {
            Task t1 = Task.Run(() =>
            {
                if (value == 1)
                {
                    // Removing the following line will change the output
                    Thread.Sleep(10);
                    Console.WriteLine("writing in t1");
                    value = 2;
                }
            });

            Task t2 = Task.Run(() =>
            {
                Console.WriteLine("writing in t2");
                value = 3;
            });

            Task t3 = Task.Run(() =>
            {
                Console.WriteLine("writing in t3");
                Interlocked.CompareExchange(ref value, 5, 3);
            });

            Task.WaitAll(t1, t2, t3);
            Console.WriteLine(value);
        }
    }
}
