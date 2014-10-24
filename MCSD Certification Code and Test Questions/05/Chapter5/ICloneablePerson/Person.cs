using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneablePerson
{
    class Person : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person Manager { get; set; }

        // Return a clone of this person.
        public object Clone()
        {
            Person person = new Person();
            person.FirstName = FirstName;
            person.LastName = LastName;
            person.Manager = Manager;
            // Uncomment the following for deep clones.
            //if (Manager != null)
            //    person.Manager = (Person)Manager.Clone();
            return person;
        }

        // Return a textual representation of the Person.
        public override string ToString()
        {
            string text = FirstName + " " + LastName;
            if (Manager != null)
                text += " (Manager: " + Manager.ToString() + ")";
            return text;
        }
    }
}
