using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8
{
    [MyCustom(Property1 = true, Property2 = "Hello World", Property3 = MyCustomAttribute.MyCustomAttributeEnum.Red)]
    class MyTestClass
    {
    }
}
