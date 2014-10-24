using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace Chapter9
{
    class StackSamples
    {
        static void Main(string[] args)
        {
            Sample1();
        }

        static void Sample1()
        {
            Stack myStack = new Stack();

            myStack.Push("first");
            myStack.Push("second");
            myStack.Push("third");

            int count = myStack.Count;
            for (int i = 0; i < count; i++)
            {
                Debug.WriteLine(myStack.Pop());
            }
        }        
    }
}
