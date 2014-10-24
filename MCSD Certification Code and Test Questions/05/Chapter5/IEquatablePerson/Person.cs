using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEquatablePerson
{
    class Person : IEquatable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool Equals(Person other)
        {
            return ((FirstName == other.FirstName) &&
                (LastName == other.LastName));
        }
    }
}
