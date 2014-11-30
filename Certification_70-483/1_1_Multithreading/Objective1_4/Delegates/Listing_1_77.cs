using Certification.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_4.Delegates
{
    public class Listing_1_77 : IRunnable
    {
        //Covariance
        public delegate TextWriter CovarianceDel();

        public StreamWriter MethodStream() { return null; }
        public StringWriter MethodString() { return null; }

        public void Run()
        {
            CovarianceDel del;
            del = MethodStream;
            del = MethodString;
        }
    }
}
