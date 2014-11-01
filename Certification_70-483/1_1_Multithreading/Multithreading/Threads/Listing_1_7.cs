namespace Certification.Chapter1.Multithreading.Threads
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
