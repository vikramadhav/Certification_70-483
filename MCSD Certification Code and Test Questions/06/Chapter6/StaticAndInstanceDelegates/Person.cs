using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndInstanceDelegates
{
    class Person
    {
        public string Name;

        // A method that returns a string.
        public delegate string GetStringDelegate();

        // A static method.
        public static string StaticName()
        {
            return "Static";
        }

        // Return this instance's Name.
        public string GetName()
        {
            return Name;
        }

        // Variables to hold GetStringDelegates.
        public GetStringDelegate StaticMethod;
        public GetStringDelegate InstanceMethod;
    }
}
