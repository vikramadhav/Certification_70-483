using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    using System.Threading;

    using Multithreading;

    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter the listing number:");
                var number = Console.ReadLine();

                switch (number)
                {
                    case "0":
                        Console.WriteLine("Bye bye pov' type");
                        Thread.Sleep(5000);
                        return;
                    case "1.1":
                        Listing_1_1.Run();
                        break;
                    case "1.2":
                        Listing_1_2.Run();
                        break;
                    case "1.3":
                        Listing_1_3.Run();
                        break;
                    case "1.4":
                        Listing_1_4.Run();
                        break;
                    case "1.5":
                        Listing_1_5.Run();
                        break;
                    case "1.6":
                        Listing_1_6.Run();
                        break;
                    case "1.7":
                        Listing_1_7.Run();
                        break;
                    case "1.8":
                        Listing_1_8.Run();
                        break;
                    case "1.9":
                        Listing_1_9.Run();
                        break;
                }
            }
        }
    }
}
