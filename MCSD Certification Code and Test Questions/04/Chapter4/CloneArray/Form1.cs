using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloneArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make an array of numbers.
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // This doesn't work because array1.Clone is an object.
            //int[] array2 = array1.Clone();

            // This works.
            int[] array3 = (int[])array1.Clone();
            array3[5] = 55;

            // This also works.
            dynamic array4 = array1.Clone();
            array4[6] = 66;

            array4[7] = "This won't work";
        }
    }
}
