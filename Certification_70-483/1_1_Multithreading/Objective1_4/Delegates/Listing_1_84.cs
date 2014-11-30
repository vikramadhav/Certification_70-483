using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_4.Delegates
{
    public class Listing_1_84 : IRunnable
    {
        public void Run()
        {
            Pub_1_84 p = new Pub_1_84();
            p.OnChange += (sender, e)
            => Console.WriteLine("Event raised: {0}", e.Value);
            p.Raise();
        }
    }

    public class MyArgs : EventArgs
    {
        public MyArgs(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
    }

    public class Pub_1_84
    {
        public event EventHandler<MyArgs> OnChange = delegate { };
        public void Raise()
        {
            OnChange(this, new MyArgs(42));
        }
    }
}
