namespace Multithreading
{
    using System;
    using System.Threading.Tasks;

    public class Listing_1_8
    {
        public static void Run()
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
