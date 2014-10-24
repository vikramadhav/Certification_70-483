using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace Chapter9
{
    class HashTableSamples
    {
        static void Main(string[] args)
        {
            Sample1();
        }

        static void Sample1()
        {
            Hashtable myHashtable = new Hashtable();

            myHashtable.Add(1, "one");
            myHashtable.Add("two", 2);
            myHashtable.Add(3, "three");

            Debug.WriteLine(myHashtable[1].ToString());
            Debug.WriteLine(myHashtable["two"].ToString());
            Debug.WriteLine(myHashtable[3].ToString());
        }
    }
}
