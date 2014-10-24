using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottery_program
{
    class Program
    {
        static void Main(string[] args)
        {
            // used to set up a range of values to choose from
            int[] range = new int[49];

            // used to simulate lottery numbers chosen
            int[] picked = new int[6];

            // set up a random number generator
            Random rnd = new Random();

            // populate the range with values from 1 to 49
            for (int i = 0; i < 49; i++)
            {
                range[i] = i + 1;
            }

            // pick 6 random numbers
            for (int limit = 0; limit < 49; limit++)
            {
                for (int select = 0; select < 6; select++)
                {
                    picked[select] = range[rnd.Next(49)];
                }

            }
            Console.WriteLine("Your lotto numbers are:");
            for (int j = 0; j < 6; j++)
            {
                Console.Write(" " + picked[j] + " ");
            }
            Console.WriteLine();

        }
    }
}
