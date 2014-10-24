using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_Multithreading
{
    class Listing_1_10
    {
        public static void Run()
        {
            Task<int> t = Task.Run(
                () =>
                    {
                        return 42;
                    }).ContinueWith(
                        (i) =>
                            {
                                return i.Result * 2;
                            });

            Console.WriteLine(t.Result); // Displays 84
        }
    }
}
