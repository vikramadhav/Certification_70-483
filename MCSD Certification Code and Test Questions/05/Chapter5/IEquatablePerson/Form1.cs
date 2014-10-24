using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEquatablePerson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The List of Persons.
        private List<Person> People = new List<Person>();

        // Add a Person to the List.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Make the new Person.
            Person person = new Person()
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text
            };

            if (People.Contains(person))
            {
                MessageBox.Show("The list already contains this person.");
            }
            else
            {
                People.Add(person);
                firstNameTextBox.Clear();
                lastNameTextBox.Clear();
                firstNameTextBox.Focus();
            }
        }
    }
}
