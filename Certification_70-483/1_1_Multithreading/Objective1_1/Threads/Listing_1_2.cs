namespace Certification.Chapter1.Objective1_1.Threads
{
    using Certification.Common;
    using System;
    using System.Threading;

    public class Listing_1_2 : IRunnable
    {
        public void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }
        public void Run()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            //t.IsBackground = true;
            t.IsBackground = false;
            t.Start();
        }
    }
}
