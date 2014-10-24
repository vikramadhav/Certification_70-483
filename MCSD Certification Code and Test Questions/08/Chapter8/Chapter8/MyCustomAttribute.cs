using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8
{
    [System.AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    class MyCustomAttribute : System.Attribute
    {
        public enum MyCustomAttributeEnum
        {
            Red,
            White,
            Blue
        }

        public bool Property1 { get; set; }
        public string Property2 { get; set; }
        public MyCustomAttributeEnum Property3 { get; set; }
    }
}
