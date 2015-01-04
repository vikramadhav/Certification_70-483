using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_5
{
    using Certification.Common;

    public class Listing_1_94 : IRunnable
    {
        public void Run()
        {
            try
            {
                try
                {
                    throw new NotSupportedException("Hello world");
                }
                catch (Exception exception)
                {
                    exception.Data["toto"] = "tata";
                    throw;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Data["toto"]);
            }
        }
    }
}
