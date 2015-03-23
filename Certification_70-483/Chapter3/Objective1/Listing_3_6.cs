using Certification.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3.Objective1
{
    [Listing("Parsing Currencies")]
    public class Listing_3_6 : IRunnable
    {
        public void Run()
        {
            CultureInfo english = new CultureInfo("En");
            CultureInfo dutch = new CultureInfo("Nl");
            string value = "€19,95";
            decimal d = decimal.Parse(value, NumberStyles.Currency, dutch);
            Console.WriteLine(d.ToString(english)); // Displays 19.95
        }
    }
}
