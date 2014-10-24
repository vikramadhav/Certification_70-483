using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableCars
{
    class Car : IComparable<Car>
    {
        public string Name { get; set; }
        public int MaxMph { get; set; }
        public int Horsepower { get; set; }
        public decimal Price { get; set; }

        // Non-generic version.
        // Compare Cars alphabetically by Name.
        //public int CompareTo(object obj)
        //{
        //    if (!(obj is Car))
        //        throw new ArgumentException("Object is not a Car");

        //    Car other = obj as Car;
        //    return Name.CompareTo(other.Name);
        //}

        // Generic version.
        // Compare Cars alphabetically by Name.
        public int CompareTo(Car other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
