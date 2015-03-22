﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Launcher
{
    using System.Threading;

    using System.Reflection;
    using Certification.Common;

    class Program
    {
        const string typePrefix = "Listing_";

        static void Main(string[] args)
        {
            var listingAssemblies = new List<Assembly>()
            {
                Assembly.GetAssembly(typeof(Certification.Chapter1.Objective1_1.Threads.Listing_1_1)),
                Assembly.GetAssembly(typeof(Certification.Chapter2.Objective2_1.Listing_2_1)),
                Assembly.GetAssembly(typeof(Chapter3.Objective1.Listing_3_6))
            };

            var runnableTypes = listingAssemblies.SelectMany(
                a => a.GetTypes()
                      .Where(type => type != typeof(IRunnable) && typeof(IRunnable).IsAssignableFrom(type))
                );

            while (true)
            {
                Console.WriteLine("Enter the listing number:");
                var number = Console.ReadLine();
                number = number.Replace('.', '_');

                var type = runnableTypes.FirstOrDefault(t => t.Name == typePrefix + number);
                
                if (type == null)
                {
                    if (number == "0" || number == String.Empty)
                    {
                        Console.WriteLine("Bye bye pov' type");
                        Thread.Sleep(500);
                        return;
                    }

                    Console.WriteLine("Unknown listing {0}", typePrefix + number);
                }
                else
                {
                    var runnable = (IRunnable)(type.GetConstructor(new Type[0]).Invoke(new object[0]));
                    runnable.Run();
                    Console.WriteLine("_______________________________________________________");
                }
            }
        }
    }
}
