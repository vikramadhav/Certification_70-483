using Certification.Common;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_1.ConcurrentCollection
{
    public class Listing_1_29 : IRunnable
    {
        public void Run()
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            Task read = Task.Run(() =>
            {
                foreach (string v in col.GetConsumingEnumerable())
                    Console.WriteLine(v);

                Console.WriteLine("End of read task.");
            });

            Task write = Task.Run(() =>
            {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s))
                    {
                        col.CompleteAdding();
                        break;
                    }
                    col.Add(s);
                }
            });
            write.Wait();
            Thread.Sleep(1000);
        }
    }
}
