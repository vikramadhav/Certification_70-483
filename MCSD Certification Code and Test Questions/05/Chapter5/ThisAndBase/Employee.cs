using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisAndBase
{
    class Employee : Person
    {
        public string DepartmentName { get; set; }

        // Constructor with first name.
        public Employee(string firstName)
            : base(firstName)
        {
            Form1.Results += "    Employee(" + firstName + ")" +
                Environment.NewLine;
        }

        // Constructor with first and last name.
        public Employee(string firstName, string lastName)
            : base(firstName, lastName)
        {
            Form1.Results += "    Employee(" + firstName + ", " +
                lastName + ")" + Environment.NewLine;
        }

        // Constructor with first name, last name, and department name.
        public Employee(string firstName, string lastName, string departmentName)
            : this(firstName, lastName)
        {
            Form1.Results += "    Employee(" + firstName + ", " +
                lastName + ", " + departmentName + ")" + Environment.NewLine;
            DepartmentName = departmentName;
        }
    }
}
