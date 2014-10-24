﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_1_Multithreading
{
    using System.Threading;

    class Listing_1_6
    {
        public static ThreadLocal<int> _field =
new ThreadLocal<int>(() =>
{
    return Thread.CurrentThread.ManagedThreadId;
});

        public static void Run()
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
