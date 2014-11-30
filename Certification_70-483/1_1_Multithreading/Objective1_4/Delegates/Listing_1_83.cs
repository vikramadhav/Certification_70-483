using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_4.Delegates
{
    public class Listing_1_83 : IRunnable
    {
        public void Run()
        {

        }
    }

    public class Pub_1_83
    {
        public event Action OnChange = delegate { };
        public void Raise()
        {
            OnChange();
        }
    }
}
