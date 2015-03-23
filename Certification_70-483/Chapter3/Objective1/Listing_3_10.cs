using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chapter3.Objective1
{
    [Listing("RegExp")]
    public class Listing_3_10 : IRunnable
    {
        public void Run()
        {
            ShowRegExResult("1002 AZ");
            ShowRegExResult("1002  AZ");
            ShowRegExResult("0002 AZ");
            ShowRegExResult("1002AZ");
            ShowRegExResult("1002AZ");
            ShowRegExResult("1002aZ");
            ShowRegExResult("1002A2");
            ShowRegExResult("1002-AA");
        }

        static void ShowRegExResult(string zipCode)
        {
            Console.WriteLine(zipCode + ": " + ValidateZipCodeRegEx(zipCode));
        }

        static bool ValidateZipCodeRegEx(string zipCode)
        {
            Match match = Regex.Match(zipCode, @"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$", RegexOptions.IgnoreCase);
            return match.Success;
        }

    }
}
