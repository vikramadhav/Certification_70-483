using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CastingArrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Classes.
        class Person
        {
            public int number;

            public Person(int value)
            {
                number = value;
            }
            public override string ToString()
            {
                return "Person: " + number.ToString();
            }
        }
        class Employee : Person
        {
            public Employee(int value)
                : base(value)
            {
            }
        }
        class Manager : Employee
        {
            public Manager(int value)
                : base(value)
            {
            }
        }

        // Demonstrate casting arrays.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Declare and initialize an array of Employees.
            Employee[] employees = new Employee[10];
            for (int id = 0; id < employees.Length; id++)
                employees[id] = new Employee(id);

            // Implicit cast to an array of Persons.
            // (An Employee is a type of Person.)
            Person[] persons = employees;

            // Explicit cast back to an array of Employees.
            // (The Persons in the arrat happen to be Employees.)
            employees = (Employee[])persons;

            // Use the is operator.
            if (persons is Employee[])
            {
                // Treat them as Employees.
                //...
            }

            // Use the as operator.
            employees = persons as Employee[];

            // After this as statement. managers is null.
            Manager[] managers = persons as Manager[];

            // Use the is operator again, this time to see
            // if persons is compatible with Manager[].
            if (persons is Manager[])
            {
                // Treat them as Managers.
                //...
            }

            // This cast fails at run time because the array
            // holds Employees not Managers.
            managers = (Manager[])persons;

            // The following fails at run time because persons
            // actually is an array of Employee not Person.
            persons[0] = new Person(0);
        }
    }
}
