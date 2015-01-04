using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter2.Objective2_1
{
    using Certification.Common;

    public class Listing_2_1 : IRunnable
    {
        public void Run()
        {
            var p = Pet.Dog | Pet.Cat;
            var p2 = (Pet)7;
            Console.WriteLine(p.HasFlag(Pet.Dog));
            Console.WriteLine(p.ToString());
            Console.WriteLine(p2.ToString());
        }
        [Flags]
        public enum Pet
        {
            None = 0x0,
            Dog = 0x1,
            Cat = 0x2,
            Snake = 0x4
        }
    }
}
