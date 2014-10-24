using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EllipsesAndCircles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Test validation.
                Ellipse e1 = new Ellipse(new RectangleF(0, 0, -10, -10));
                Ellipse e2 = new Ellipse(0, 0, -10, -10);
                Ellipse e3 = new Ellipse(0, 0, 10, -10);
                Ellipse e4 = new Ellipse(new RectangleF(0, 0, 10, 10));
                Ellipse e5 = new Ellipse(0, 0, 10, 10);
                Circle c1 = new Circle(new RectangleF(0, 0, -10, -10));
                Circle c2 = new Circle(0, 0, -10, -10);
                Circle c3 = new Circle(0, 0, 10, -10);
                Circle c4 = new Circle(0, 0, 10, 1);
                Circle c5 = new Circle(new RectangleF(0, 0, 10, 10));
                Circle c6 = new Circle(0, 0, 10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
