using Certification.Common;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter2.Objective2_2
{
    public class Listing_2_29 : IRunnable
    {
        public void Run()
        {
            dynamic obj = new SampleObject();
            obj.SomeProperty = "test";
            obj.AnotherProperty = 67;
            Console.WriteLine(obj.SomeProperty);
            Console.WriteLine(obj.AnotherProperty);
            Console.WriteLine((string)obj.PropertyThatDoesNotExist); 
        }

        public class SampleObject : DynamicObject
        {
            private Dictionary<string, object> members = new Dictionary<string, object>();

            public override bool TryGetMember(GetMemberBinder binder, out object result)
            {
                if (!members.TryGetValue(binder.Name, out result))
                {
                    result = null;
                }

                return true;
            }

            public override bool TrySetMember(SetMemberBinder binder, object value)
            {
                members[binder.Name] = value;
                return true;
            }
        }

    }
}
