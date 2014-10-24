using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_1_Multithreading
{
    using System.Threading.Tasks;

    class Listing_1_8
    {
        public static void Run()
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write('*');
                }
            });
            t.Wait();
        }
    }
}
