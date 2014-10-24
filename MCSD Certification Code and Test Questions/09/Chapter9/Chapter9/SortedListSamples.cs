using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace Chapter9
{
    class SortedListSamples
    {
        static void Main(string[] args)
        {
            Sample1();
        }

        static void Sample1()
        {
            SortedList mySortedList = new SortedList();

            mySortedList.Add(3, "three");
            mySortedList.Add(2, "second");
            mySortedList.Add(1, "first");

            foreach (DictionaryEntry item in mySortedList)
            {
                Debug.WriteLine(item.Value);
            }
        }        
    }
}
