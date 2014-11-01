namespace Certification.Multithreading
{
    using Certification.Common;
    using System;
    using System.Threading;

    public class Listing_1_4 : IRunnable
    {
        public void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        public void Run()
        {
            bool stopped = false;
            Thread t = new Thread(
                new ThreadStart(
                    () =>
                    {
                        while (!stopped)
                        {
                            Console.WriteLine("Running...");
                            Thread.Sleep(1000);
                        }
                    }));
            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            stopped = true;
            t.Join();
        }
    }
}
