using Certification.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_4.Delegates
{
    public class Listing_1_78 : IRunnable
    {
        //Contravariance
        void DoSomething(TextWriter tw) { }
        public delegate void ContravarianceDel(StreamWriter tw);

        public void Run()
        {
            ContravarianceDel del = DoSomething;
        }
    }
}
