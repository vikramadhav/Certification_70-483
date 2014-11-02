using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_1.Parallel
{
    public class Listing_1_16 : IRunnable
    {
        public void Run()
        {
            System.Threading.Tasks.Parallel.For(0, 10, i =>
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            });
            var numbers = Enumerable.Range(0, 10);
            System.Threading.Tasks.Parallel.ForEach(numbers, i =>
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            });
        }
    }
}
