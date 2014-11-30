using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_4.Delegates
{
    public class Listing_1_85 : IRunnable
    {
        public void Run()
        {
            Pub_1_85 p = new Pub_1_85();
            p.OnChange += (sender, e)
            => Console.WriteLine("Event raised: {0}", e.Value);
            p.Raise();
        }

        public class Pub_1_85
        {
            private event EventHandler<MyArgs> onChange = delegate { };
            public event EventHandler<MyArgs> OnChange
            {
                add
                {
                    lock (onChange)
                    {
                        onChange += value;
                    }
                }
                remove
                {
                    lock (onChange)
                    {
                        onChange -= value;
                    }
                }
            }
            public void Raise()
            {
                onChange(this, new MyArgs(42));
            }
        }
    }
}
