﻿namespace Multithreading
{
    using System;
    using System.Threading;

    public class Listing_1_1
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1);
            }
        }

        public static void Run()
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
