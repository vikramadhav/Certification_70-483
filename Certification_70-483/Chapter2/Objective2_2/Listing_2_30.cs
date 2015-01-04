using Certification.Common;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter2.Objective2_2
{
    public class Listing_2_30 : IRunnable
    {
        public void Run()
        {
            dynamic test = new ExpandoObject();
            test.NewProperty = "toto";
            Console.WriteLine(test.NewProperty);
        }
    }
}
