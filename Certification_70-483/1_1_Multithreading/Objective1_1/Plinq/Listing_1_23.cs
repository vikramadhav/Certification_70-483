using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_1.Plinq
{
    public class Listing_1_23 : IRunnable
    {
        public void Run()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel().WithExecutionMode(ParallelExecutionMode.ForceParallelism)
            .Where(i => i % 2 == 0)
            .ToArray();
            foreach (int i in parallelResult)
                Console.WriteLine(i);
        }
    }
}
