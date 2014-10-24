using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Ch05RealWorldScenario02
{
    class Shape : IDisposable, IComparable<Shape>
    {
        // The FillBrush and OutlinePen properties.
        public Brush FillBrush { get; set; }
        public Pen OutlinePen  { get; set; }

        // Remember whether we've already run Dispose.
        private bool IsDisposed = false;

        // Clean up managed resources.
        public void Dispose()
        {
            // If we've already run Dispose, do nothing.
            if (IsDisposed) return;

            // Dispose of FillBrush and OutlinePen.
            FillBrush.Dispose();
            OutlinePen.Dispose();

            // Remember that we ran Dispose.
            IsDisposed = true;
        }
    }
}
