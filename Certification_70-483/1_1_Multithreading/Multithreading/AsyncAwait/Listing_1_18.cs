using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Certification.Chapter1.Multithreading.AsyncAwait
{
    public class Listing_1_18 : IRunnable
    {
        public void Run()
        {
            try
            {
                string result = DownloadContent().Result;
                Console.WriteLine(result);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Inner excpetion : {0}", e.InnerException.Message);
            }
        }

        public async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string result = await client.GetStringAsync("http://www.microsoft.com.toto").ConfigureAwait(false);
                    return result;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw e;
                }
            }
        }
    }
}
