using Certification.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_1.Plinq
{
    public class Listing_1_22 : IRunnable
    {
        public void Run()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            var numbers = Enumerable.Range(0, 100000000);
            var parallelResult = numbers.AsParallel().WithExecutionMode(ParallelExecutionMode.ForceParallelism).WithDegreeOfParallelism(3)
            .Where(i => i % 2 == 0)
            .ToArray();

            sw.Stop();
            Console.WriteLine("Plinq execution time = {0}ms", sw.ElapsedMilliseconds);

            sw.Restart();

            parallelResult = numbers
            .Where(i => i % 2 == 0)
            .ToArray();

            sw.Stop();
            Console.WriteLine("Linq execution time = {0}ms", sw.ElapsedMilliseconds);
        }
    }
}
