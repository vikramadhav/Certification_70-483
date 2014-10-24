using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Ch05RealWorldScenario01
{
    class Ellipse
    {
        public RectangleF Location { get; set; }

        // Constructor that takes a RectangleF as a parameter.
        public Ellipse(RectangleF rect)
        {
            // Validate width and height.
            if (rect.Width <= 0)
                throw new ArgumentOutOfRangeException(
                    "width",
                    "Ellipse width must be greater than 0.");
            if (rect.Height <= 0)
                throw new ArgumentOutOfRangeException(
                    "height",
                    "Ellipse height must be greater than 0.");

            // Save the location.
            Location = rect;
        }

        // Constructor that takes x, y, width, and height as parameters.
        public Ellipse(float x, float y, float width, float height)
            : this(new RectangleF(x, y, width, height))
        {
        }
    }
}
