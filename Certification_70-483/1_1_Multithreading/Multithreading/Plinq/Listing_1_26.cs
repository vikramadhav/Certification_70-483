using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Multithreading.Plinq
{
    public class Listing_1_26 : IRunnable
    {
        public void Run()
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel().AsOrdered()
            .Where(i => i % 2 == 0);

            Console.WriteLine("Sequential results:");
            foreach (int i in parallelResult)
                Console.WriteLine(i);

            Console.WriteLine("Parallel results:");
            parallelResult.ForAll(e => Console.WriteLine(e));
        }
    }
}
