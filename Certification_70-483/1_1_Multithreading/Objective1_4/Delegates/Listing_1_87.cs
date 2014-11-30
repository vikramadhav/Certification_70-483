using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter1.Objective1_4.Delegates
{
    public class Listing_1_87 : IRunnable
    {
        public void Run()
        {
            Pub_1_87 p = new Pub_1_87();
            p.OnChange += (sender, e)
            => Console.WriteLine("Subscriber 1 called");
            p.OnChange += (sender, e)
            => { throw new Exception(); };
            p.OnChange += (sender, e)
            => Console.WriteLine("Subscriber 3 called");
            try
            {
                p.Raise();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.InnerExceptions.Count);
            }
        }

        public class Pub_1_87
        {
            public event EventHandler OnChange = delegate { };
            public void Raise()
            {
                var exceptions = new List<Exception>();
                foreach (Delegate handler in OnChange.GetInvocationList())
                {
                    try
                    {
                        handler.DynamicInvoke(this, EventArgs.Empty);
                    }
                    catch (Exception ex)
                    {
                        exceptions.Add(ex);
                    }
                }
                if (exceptions.Any())
                {
                    throw new AggregateException(exceptions);
                }
            }
        }
    }
}
