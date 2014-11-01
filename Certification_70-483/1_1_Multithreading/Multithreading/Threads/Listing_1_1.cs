namespace Certification.Chapter1.Multithreading.Threads
{
    using System;
    using System.Threading;
    using Certification.Common;

    public class Listing_1_1 : IRunnable
    {
        public void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1);
            }
        }

        public void Run()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(1);
            }
            t.Join();
        }
    }
}
