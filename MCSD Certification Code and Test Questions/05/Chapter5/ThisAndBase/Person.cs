using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisAndBase
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor with first name.
        public Person(string firstName)
        {
            Form1.Results += "  Person(" + firstName + ")" +
                Environment.NewLine;
            FirstName = firstName;
        }

        // Constructor with first and last name.
        public Person(string firstName, string lastName)
            : this(firstName)
        {
            Form1.Results += "  Person(" + firstName + ", " +
                lastName + ")" + Environment.NewLine;
            LastName = lastName;
        }
    }
}
