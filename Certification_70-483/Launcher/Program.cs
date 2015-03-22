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
    using System.Text.RegularExpressions;

    class Program
    {
        const string typePrefix = "Listing_";
        const string listingRegExp = "^[0-9]+.[0-9]+$";
        const string chapterRegExp = "^[0-9]+$";

        static void Main(string[] args)
        {
            var assemblyDictionary = new Dictionary<int, Assembly>()
            {
                { 1, Assembly.GetAssembly(typeof(Certification.Chapter1.Objective1_1.Threads.Listing_1_1)) },
                { 2 , Assembly.GetAssembly(typeof(Certification.Chapter2.Objective2_1.Listing_2_1)) },
                { 3, Assembly.GetAssembly(typeof(Chapter3.Objective1.Listing_3_6)) }
            };

            var typeDictionary = new Dictionary<int, IEnumerable<Type>>();
            foreach (var kvp in assemblyDictionary)
            {
                typeDictionary.Add(kvp.Key, kvp.Value.GetTypes()
                      .Where(type => type != typeof(IRunnable) && typeof(IRunnable).IsAssignableFrom(type)));
            }

            while (true)
            {
                Console.WriteLine("Enter the listing number:");
                var input = Console.ReadLine();

                bool isListing = Regex.IsMatch(input, listingRegExp);
                bool isChapter = Regex.IsMatch(input, chapterRegExp);

                if (isChapter)
                {
                    IEnumerable<Type> listings;
                    var chapterNumber = int.Parse(input);

                    if (typeDictionary.TryGetValue(chapterNumber, out listings))
                    {
                        Console.WriteLine("Available listing are:");
                        var listingNames = listings.Select(l => l.Name.Replace(typePrefix, string.Empty).Replace("_", "."));

                        foreach (var listing in listings.OrderBy(l => GetListingNumber(l)))
                        {
                            var displayName = listing.Name.Replace(typePrefix, string.Empty).Replace("_", ".");
                            var listingAttribute = (ListingAttribute)Attribute.GetCustomAttribute(listing, typeof(ListingAttribute));

                            if (listingAttribute != null)
                            {
                                displayName += " - " + listingAttribute.Description;
                            }

                            Console.WriteLine(displayName);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Chapter " + input + " is unknown.");
                    }
                }
                else if (isListing)
                {
                    input = input.Replace('.', '_');

                    var type = typeDictionary.SelectMany(kvp => kvp.Value).FirstOrDefault(t => t.Name == typePrefix + input);

                    if (type == null)
                    {
                        Console.WriteLine("Unknown listing {0}", typePrefix + input);
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
                else if (input == "0" || input == String.Empty)
                {
                    Console.WriteLine("Bye bye pov' type");
                    Thread.Sleep(500);
                    return;
                }
            }
        }

        static int GetListingNumber(Type listing)
        {
            var displayName = GetListingName(listing);
            var dotPosition = displayName.IndexOf(".");

            return int.Parse(displayName.Substring(dotPosition + 1));
        }

        static string GetListingName(Type listing)
        {
            return listing.Name.Replace(typePrefix, string.Empty).Replace("_", ".");
        }
    }
}
