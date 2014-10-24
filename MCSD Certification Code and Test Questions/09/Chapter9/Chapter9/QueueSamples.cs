using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace Chapter9
{
    class QueueSamples
    {
        static void Main(string[] args)
        {
            Sample1();
        }

        static void Sample1()
        {
            Queue myQueue = new Queue();

            myQueue.Enqueue("first");
            myQueue.Enqueue("second");
            myQueue.Enqueue("third");

            int count = myQueue.Count;
            for (int i = 0; i < count; i++)
            {
                Debug.WriteLine(myQueue.Dequeue());
            }
        }        
    }
}
