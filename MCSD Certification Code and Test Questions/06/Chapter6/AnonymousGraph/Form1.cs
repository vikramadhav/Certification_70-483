using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace AnonymousGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The function we are currently drawing.
        private Func<float, float> TheFunction;

        // Select the first equation.
        private void Form1_Load(object sender, EventArgs e)
        {
            equationComboBox.SelectedIndex = 0;
        }

        // Draw the currently selected function.
        private void graphPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            DrawGraph(e.Graphics);
        }

        // Draw the graph.
        private void DrawGraph(Graphics gr)
        {
            // Map to turn right-side up and center at the origin.
            const float wxmin = -10;
            const float wymin = -10;
            const float wxmax = 10;
            const float wymax = 10;
            RectangleF rect = new RectangleF(wxmin, wymin, wxmax - wxmin, wymax - wymin);
            PointF[] pts = 
            {
                new PointF(0, graphPictureBox.ClientSize.Height),
                new PointF(graphPictureBox.ClientSize.Width, graphPictureBox.ClientSize.Height),
                new PointF(0, 0),
            };
            Matrix transform = new Matrix(rect, pts);
            gr.Transform = transform;

            // See how far it is between horizontal pixels in world coordinates.
            pts = new PointF[] { new PointF(1, 0) };
            transform.Invert();
            transform.TransformVectors(pts);
            float dx = pts[0].X;

            // Generate points on the curve.
            List<PointF> points = new List<PointF>();
            for (float x = wxmin; x <= wxmax; x += dx)
                points.Add(new PointF(x, TheFunction(x)));

            // Use a thin pen.
            using (Pen thin_pen = new Pen(Color.Gray, 0))
            {
                // Draw the coordinate axes.
                gr.DrawLine(thin_pen, wxmin, 0, wxmax, 0);
                gr.DrawLine(thin_pen, 0, wymin, 0, wymax);
                for (float x = wxmin; x <= wxmax; x++)
                    gr.DrawLine(thin_pen, x, -0.5f, x, 0.5f);
                for (float y = wymin; y <= wymax; y++)
                    gr.DrawLine(thin_pen, -0.5f, y, 0.5f, y);

                // Draw the graph.
                thin_pen.Color = Color.Red;
                //thin_pen.Color = Color.Black;
                gr.DrawLines(thin_pen, points.ToArray());
            }
        }

        // Select the appropriate function and redraw.
        private void equationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (equationComboBox.SelectedIndex)
            {
                case 0:     // y = 12 * Sin(3 * x) / (1 + |x|)
                    // Using statement lambda syntax.
                    TheFunction = x => (float)(12 * Math.Sin(3 * x) / (1 + Math.Abs(x)));
                    break;
                case 1:     // y = |20 * Cos(|x|) / (|x| + 1)|
                    // Using anonymous method delegate syntax.
                    TheFunction = delegate(float x)
                        {
                            x = Math.Abs(x);
                            if (x < 0.001) return 20;
                            return (float)Math.Abs(20 * Math.Cos(x) / (x + 1));
                        };
                    break;
                case 2:     // y = Ax^6 + Bx^5 + Cx^4 + Dx^3 + Ex^2 + Fx + G.
                    // Using statement lambda syntax.
                    TheFunction = (float x) =>
                        {
                            const float A = -0.0003f;
                            const float B = -0.0024f;
                            const float C = 0.02f;
                            const float D = 0.09f;
                            const float E = -0.5f;
                            const float F = 0.3f;
                            const float G = 3f;
                            return (((((A * x + B) * x + C) * x + D) * x + E) * x + F) * x + G;
                        };
                    break;
            }
            graphPictureBox.Refresh();
        }
    }
}
