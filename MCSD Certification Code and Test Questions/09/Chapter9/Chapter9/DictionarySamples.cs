using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Chapter9
{
    class DictionarySamples
    {
        static void Main(string[] args)
        {
            Sample1();
        }

        static void Sample1()
        {
            Dictionary<int, MyRecord> myDictionary = new Dictionary<int, MyRecord>();

            myDictionary.Add(5, new MyRecord() { ID = 5, FirstName = "Bob", LastName = "Smith" });
            myDictionary.Add(2, new MyRecord() { ID = 2, FirstName = "Jane", LastName = "Doe" });
            myDictionary.Add(10, new MyRecord() { ID = 10, FirstName = "Bill", LastName = "Jones" });

            Debug.WriteLine(myDictionary[5].FirstName);
            Debug.WriteLine(myDictionary[2].FirstName);
            Debug.WriteLine(myDictionary[10].FirstName);

        }
    }

    class MyRecord
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
