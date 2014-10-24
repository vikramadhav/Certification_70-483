using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Ch05RealWorldScenario01
{
    class Circle : Ellipse
    {
        // Constructor that takes a RectangleF as a parameter.
        public Circle(RectangleF rect)
            : base(rect)
        {
            // Validate width and height.
            if (rect.Width != rect.Height)
                throw new ArgumentOutOfRangeException(
                    "width and height",
                    "Circle width and height must be the same.");
        }

        // Constructor that takes x, y, width, and height as parameters.
        public Circle(float x, float y, float width, float height)
            : this(new RectangleF(x, y, width, height))
        {
        }
    }
}
