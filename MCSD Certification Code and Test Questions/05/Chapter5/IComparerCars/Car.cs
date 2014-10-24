using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparerCars
{
    class Car
    {
        public string Name { get; set; }
        public int MaxMph { get; set; }
        public int Horsepower { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1}mph, {2}hp, {3:C}",
                Name, MaxMph, Horsepower, Price);
        }
    }
}
