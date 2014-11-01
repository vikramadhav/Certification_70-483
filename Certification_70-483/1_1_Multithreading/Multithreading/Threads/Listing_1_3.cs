namespace Certification.Chapter1.Multithreading.Threads
{
    using Certification.Common;
    using System;
    using System.Threading;

    public class Listing_1_3 : IRunnable
    {
        public void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine(
                    "ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        public void Run()
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(10);
            t.Join();
        }
    }
}
