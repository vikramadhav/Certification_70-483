namespace Multithreading
{
    using System;
    using System.Threading;

    public class Listing_1_7
    {
        public static void Run()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool");
            });
            Console.ReadLine();
        }
    }
}
