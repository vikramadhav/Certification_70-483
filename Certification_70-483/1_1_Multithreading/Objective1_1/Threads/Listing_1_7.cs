namespace Certification.Chapter1.Objective1_1.Threads
{
    using Certification.Common;
    using System;
    using System.Threading;

    public class Listing_1_7 : IRunnable
    {
        public void Run()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool");
            });
            Console.ReadLine();
        }
    }
}
