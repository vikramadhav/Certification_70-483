using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_2.CancelTasks
{
    public class Listing_1_45 : IRunnable
    {
        public void Run()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task longRunning = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    token.ThrowIfCancellationRequested();
                    Thread.Sleep(1000);
                }
            }, token);

            longRunning.ContinueWith((t) =>
                {
                    Console.WriteLine("Task was canceled");
                }, TaskContinuationOptions.OnlyOnCanceled);
            longRunning.ContinueWith((t) =>
                {
                    Console.WriteLine("Task ran successfully");
                }, TaskContinuationOptions.OnlyOnRanToCompletion);
            longRunning.ContinueWith((t) =>
            {
                Console.WriteLine("Task faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);


            cancellationTokenSource.CancelAfter(1000);
            //int index = Task.WaitAny(new[] { longRunning }, 1000);
            //if (index == -1)
            //{
            //    Console.WriteLine("Task timed out");
            //    cancellationTokenSource.Cancel();
            //}

        }
    }
}
