using System;
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
            Assembly multithreadingAssembly = Assembly.GetAssembly(typeof(Certification.Chapter1.Objective1_1.Threads.Listing_1_1));
            Assembly chapter2Assembly = Assembly.GetAssembly(typeof(Certification.Chapter2.Objective2_1.Listing_2_1));
            var runnableTypes =
                multithreadingAssembly.GetTypes()
                    .Where(type => type != typeof(IRunnable) && typeof(IRunnable).IsAssignableFrom(type))
                    .Union(
                        chapter2Assembly.GetTypes()
                            .Where(type => type != typeof(IRunnable) && typeof(IRunnable).IsAssignableFrom(type)));

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
                    var listingAttribute = (ListingAttribute)Attribute.GetCustomAttribute(type, typeof(ListingAttribute));

                    if (listingAttribute != null)
                    {
                        Console.WriteLine("Running listing \"" + listingAttribute.Description + "\"");
                        Console.WriteLine();
                    }
                    runnable.Run();
                    Console.WriteLine("_______________________________________________________");
                }
            }
        }
    }
}
