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
    public class Listing_1_31 : IRunnable
    {
        public void Run()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            var continuationTask = Task.Run(() =>
            {
                bag.Add(42);
                Thread.Sleep(1000);
                bag.Add(21);
            }).ContinueWith((t) =>
                {
                    Console.WriteLine("Second iteration.");
                    foreach (int i in bag)
                        Console.WriteLine(i);
                }
            );
            Task.Run(() =>
            {
                foreach (int i in bag)
                    Console.WriteLine(i);
            }).Wait();
            continuationTask.Wait();
        }
    }
}
