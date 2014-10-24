using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_enums
{
    class Program
    {
        enum Months
        {
            Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sept,
            Oct, Nov, Dec
        };

        static void Main(string[] args)
        {
            string name = Enum.GetName(typeof(Months), 8);
            Console.WriteLine("The 8th month in the enum is " + name);

            Console.WriteLine("The underlying values of the Months enum:");
            foreach (int values in Enum.GetValues(typeof(Months)))
            {
                Console.WriteLine(values);
            }
        }

    }
}
