namespace Multithreading
{
    using System;
    using System.Threading.Tasks;

    public class Listing_1_9
    {
        public static void Run()
        {
            Task<int> t = Task.Run(
                () =>
                {
                    throw new Exception();
                    return 42;
                });


            t.ContinueWith((i) => Console.WriteLine("Canceled"), TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith((i) => Console.WriteLine("Faulted"), TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = t.ContinueWith((i) =>
            {
                Console.WriteLine(i.Result * 2);
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();

            Console.ReadKey();
        }
    }
}
