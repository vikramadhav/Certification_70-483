using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_2.CancelTasks
{
    public class Listing_1_44 : IRunnable
    {
        public void Run()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }
                token.ThrowIfCancellationRequested();
            }, token).ContinueWith((t) =>
            {
                //t.Exception.Handle((e) => true);
                Console.WriteLine("You have canceled the task");
            }, TaskContinuationOptions.OnlyOnCanceled);

            Console.WriteLine("Press enter to stop the task");
            Console.ReadLine();
            cancellationTokenSource.Cancel();
            Console.WriteLine("Press enter to end the application");
            Console.ReadLine();
        }
    }
}
