using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    class ListSamples
    {
        static void Main(string[] args)
        {
            Sample1();
        }

        static void Sample1()
        {
            List<int> myList = new List<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
        }        
    }
}
