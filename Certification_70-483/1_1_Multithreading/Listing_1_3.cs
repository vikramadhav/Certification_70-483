using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_1_Multithreading
{
    using System.Threading;

    internal class Listing_1_3
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine(
                    "ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void Run()
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(10);
            t.Join();
        }
    }
}
