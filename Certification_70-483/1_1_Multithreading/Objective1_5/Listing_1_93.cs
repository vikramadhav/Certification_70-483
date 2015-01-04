using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_5
{
    using System.Threading;

    using Certification.Common;

    public class Listing_1_93 : IRunnable
    {
        public void Run()
        {
            try
            {
                Thread t = new Thread(
                    () =>
                    {
                        Thread.Sleep(1000);
                        throw new Exception("Pas content");
                    });

                t.Start();
                t.Join();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception handled.");
            }
            Console.WriteLine("Program ended.");
        }
    }
}
