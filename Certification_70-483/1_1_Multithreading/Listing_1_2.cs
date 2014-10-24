﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_1_Multithreading
{
    using System.Threading;

    class Listing_1_2
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }
        public static void Run()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            //t.IsBackground = true;
            t.IsBackground = false;
            t.Start();
        }
    }
}
