using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonHierarchy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person person = new Person("Ann", "Archer");
            Employee employee = new Employee("Ben", "Baker", "Information Technology");
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName)
        {
            // Validate the first and last names.
            if ((firstName == null) || (firstName.Length < 1))
                throw new ArgumentOutOfRangeException(
                    "firstName", firstName,
                    "FirstName must not be null or blank.");
            if ((lastName == null) || (lastName.Length < 1))
                throw new ArgumentOutOfRangeException(
                    "lastName", lastName,
                    "LastName must not be null or blank.");

            // Save the first and last names.
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class Employee : Person
    {
        public string DepartmentName { get; set; }
        public Employee(string firstName, string lastName, string departmentName)
            : base(firstName, lastName)
        {
            // Validate the department name.
            if ((departmentName == null) || (departmentName.Length < 1))
                throw new ArgumentOutOfRangeException(
                    "departmentName", departmentName,
                    "DepartmentName must not be null or blank.");

            // Save the department name.
            DepartmentName = departmentName;
        }
    }
}
