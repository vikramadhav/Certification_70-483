namespace Certification.Chapter1.Multithreading.Threads
{
    using Certification.Common;
    using System;
    using System.Threading;

    public class Listing_1_5 : IRunnable
    {
        [ThreadStatic]
        public static int _field;

        public void Run()
        {
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }
            }).Start();
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();
        }
    }
}
