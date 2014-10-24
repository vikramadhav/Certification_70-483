using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovarianceAndContravariance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // A delegate that returns a Person.
        private delegate Person ReturnPersonDelegate();
        //private ReturnPersonDelegate ReturnPersonMethod;
        private Func<Person> ReturnPersonMethod;

        // A method that returns an Employee.
        private Employee ReturnEmployee()
        {
            return new Employee();
        }

        // A delegate that takes an Employee as a parameter.
        private delegate void EmployeeParameterDelegate(Employee employee);
        private EmployeeParameterDelegate EmployeeParameterMethod;
        //private Action<Employee> EmployeeParameterMethod;

        // A method that takes a Person as a parameter.
        private void PersonParameter(Person person)
        {
        }

        // Initialize delegate variables.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set ReturnPersonMethod = ReturnEmployee.
            // Covariance allows this because ReturnPersonDelegate
            // returns a Person and an Employee is a kind of Person.
            ReturnPersonMethod = ReturnEmployee;

            // Set EmployeeParameterMethod = PersonParameter.
            // Contravariance allows this because EmployeeParameterDelegate
            // takes an Employee as a parameter and an Employee is a kind of Person.
            // In other words, when you invoke the delegate's method you will
            // pass it an Employee and an Employee is a kind of Person so
            // PersonParameter can handle it.
            EmployeeParameterMethod = PersonParameter;
        }
    }
}
