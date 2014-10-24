using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8
{
    class Calculator
    {
        private double _x;
        private double _y;

        public double X
        {
            get { return this._x; }
            set { this._x = value; }
        }

        public double Y
        {
            get { return this._y; }
            set { this._y = value; }
        }

        public double Divide()
        {
            if (this.Y == 0)
            {
                return 0;
            }
            else
            {
                return this.X / this.Y;
            }
        }

        public double Exponent(double power)
        {
            return Math.Pow(this.X, power);
        }
    }
}
