using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparablePerson
{
    class Person : IComparable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Return the full name.
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        // Compare our Name with another Person's Name.
        public int CompareTo(Person other)
        {
            return ToString().CompareTo(other.ToString());
        }
    }
}
