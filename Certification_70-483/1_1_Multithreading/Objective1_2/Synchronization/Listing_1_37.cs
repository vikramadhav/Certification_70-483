using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_2.Synchronization
{
    public class Listing_1_37 : IRunnable
    {
        public void Run()
        {
            object lockA = new object();
            object lockB = new object();
            var up = Task.Run(() =>
            {
                lock (lockA)
                {
                    Thread.Sleep(1000);
                    lock (lockB)
                    {
                        Console.WriteLine("Locked A and B");
                    }
                }
            });
            lock (lockB)
            {
                Thread.Sleep(1000);
                lock (lockA)
                {
                    Console.WriteLine("Locked A and B");
                }
            }
            up.Wait();
        }
    }
}
