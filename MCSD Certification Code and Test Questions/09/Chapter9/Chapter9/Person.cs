using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace Chapter9
{    
    class Person
    {
        public int PersonId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }

    class PersonCollection : CollectionBase
    {
        public void Add(Person person)
        {
            List.Add(person);
        }

        public void Insert(int index, Person person)
        {
            List.Insert(index, person);
        }

        public Person this[int index]
        {
            get
            {
                return (Person)List[index];
            }

            set
            {
                List[index] = value;
            }
        }

        public void Remove(Person person)
        {
            List.Remove(person);
        }
    }
}
