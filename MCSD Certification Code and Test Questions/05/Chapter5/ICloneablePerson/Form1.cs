using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICloneablePerson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Make some Persons.
        private void Form1_Load(object sender, EventArgs e)
        {
            Person ann = new Person()
            {
                FirstName = "Ann",
                LastName = "Archer",
                Manager = null
            };
            Person bob = new Person()
            {
                FirstName = "Bob",
                LastName = "Baker",
                Manager = ann
            };
            Person bob2 = (Person)bob.Clone();
            Person cindy = new Person()
            {
                FirstName = "Cindy",
                LastName = "Cane",
                Manager = bob
            };

            // Change Bob's manager's name.
            bob.Manager.FirstName = "Dan";
            bob.Manager.LastName = "Dent";

            // Display the people.
            peopleListBox.Items.Add(ann);
            peopleListBox.Items.Add(bob);
            peopleListBox.Items.Add(bob2);
            peopleListBox.Items.Add(cindy);
        }
    }
}
