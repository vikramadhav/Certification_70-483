using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_4.Delegates
{
    public class Listing_1_86 : IRunnable
    {
        public void Run()
        {
            Pub_1_86 p = new Pub_1_86();
            p.OnChange += (sender, e)
            => Console.WriteLine("Subscriber 1 called");
            p.OnChange += (sender, e)
            => { throw new Exception("2"); };
            p.OnChange += (sender, e)
            => Console.WriteLine("Subscriber 3 called");

            try
            {
                p.Raise();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception raise : {0}", ex.Message);
            }
        }
    }

    public class Pub_1_86
    {
        public event EventHandler OnChange = delegate { };
        public void Raise()
        {
            OnChange(this, EventArgs.Empty);
        }
    }
}
