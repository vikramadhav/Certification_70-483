﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _1_1_Multithreading
{
    using System.Threading;

    internal class Listing_1_4
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void Run()
        {
            bool stopped = false;
            Thread t = new Thread(
                new ThreadStart(
                    () =>
                    {
                        while (!stopped)
                        {
                            Console.WriteLine("Running...");
                            Thread.Sleep(1000);
                        }
                    }));
            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            stopped = true;
            t.Join();
        }
    }
}
