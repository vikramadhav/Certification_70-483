using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_1.Parallel
{
    public class Listing_1_17 : IRunnable
    {
        public void Run()
        {
            ParallelLoopResult result = System.Threading.Tasks.Parallel.
                For(0, 1000, (int i, ParallelLoopState loopState) =>
{
    if (i == 500)
    {
        Console.WriteLine("Breaking loop at {0}",i);
        loopState.Break();
    }
    return;
});
        }
    }
}
