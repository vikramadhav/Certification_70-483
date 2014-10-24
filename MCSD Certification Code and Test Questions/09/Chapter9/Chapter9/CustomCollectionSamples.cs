using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Chapter9
{
    class CustomCollectionSamples
    {
        static void Main(string[] args)
        {
            PersonCollection persons = new PersonCollection();

            persons.Add(new Person()
            {
                PersonId = 1,
                FName = "John",
                LName = "Smith"
            });

            persons.Add(new Person()
            {
                PersonId = 2,
                FName = "Jane",
                LName = "Doe"
            });

            persons.Add(new Person()
            {
                PersonId = 3,
                FName = "Bill Jones",
                LName = "Smith"
            });

            foreach (Person person in persons)
            {
                Debug.WriteLine(person.FName);
            }
        }
    }
}
