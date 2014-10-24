using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisAndBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string Results = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make some Persons.
            Results += "Making Person(Bea)" + Environment.NewLine;
            Person bea = new Person("Bea");
            Results += Environment.NewLine;

            Results += "Making Person(Al, Able)" + Environment.NewLine;
            Person al = new Person("Al", "Able");
            Results += Environment.NewLine;

            // Make some Employees.
            Results += "Making Employee(Carl)" + Environment.NewLine;
            Person carl = new Employee("Carl");
            Results += Environment.NewLine;

            Results += "Making Employee(Deb, Dart)" + Environment.NewLine;
            Person deb = new Employee("Deb", "Dart");
            Results += Environment.NewLine;

            Results += "Making Employee(Ed, Eager, IT)" + Environment.NewLine;
            Person ed = new Employee("Ed", "Eager", "IT");
            Results += Environment.NewLine;

            // Display the results.
            resultsTextBox.Text = Results;
            resultsTextBox.Select(0, 0);
        }
    }
}
