namespace Certification.Chapter1.Objective1_1.Tasks
{
    using Certification.Common;
    using System;
    using System.Threading.Tasks;

    public class Listing_1_8 : IRunnable
    {
        public void Run()
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write('*');
                }
            });
            t.Wait();
        }
    }
}
