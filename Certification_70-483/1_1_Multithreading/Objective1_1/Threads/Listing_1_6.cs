namespace Certification.Chapter1.Objective1_1.Threads
{
    using Certification.Common;
    using System;
    using System.Threading;

    public class Listing_1_6 : IRunnable
    {
        public ThreadLocal<int> _field =
new ThreadLocal<int>(() =>
{
    return Thread.CurrentThread.ManagedThreadId;
});

        public void Run()
        {
            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread A: {0}", x);
                }
            }).Start();
            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread B: {0}", x);
                }
            }).Start();
        }
    }
}
