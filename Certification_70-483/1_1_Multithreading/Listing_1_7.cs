using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_1_Multithreading
{
    using System.Threading;

    class Listing_1_7
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
