using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Chapter2.Objective2_2
{
    /// <summary>
    /// Conversion
    /// </summary>
    public class Listing_2_24 : IRunnable
    {
        public void Run()
        {
            var money = new Money(100.5M);
            decimal moneyDec = money; //implicit conversion
            int moneyInt = (int)money; //Exeplicit conversion

            Console.WriteLine(moneyDec);
            Console.WriteLine(moneyInt);
        }

        class Money
        {
            public Money(decimal amount) { Amount = amount; }

            public decimal Amount { get; set; }

            /// <summary>
            /// Implicit conversion
            /// </summary>
            /// <param name="money"></param>
            /// <returns></returns>
            public static implicit operator decimal(Money money) { return money.Amount; }

            /// <summary>
            /// Explicit conversion
            /// </summary>
            /// <param name="money"></param>
            /// <returns></returns>
            public static explicit operator int(Money money) { return (int)money.Amount; }
        }

    }


}
