using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace working_with_for_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // using a for loop to count up by one
            Console.WriteLine("Count up by one");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // using a for loop to count down by one
            Console.WriteLine("Count down by one");

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // using a for loop to count up by 2
            Console.WriteLine("Count up by two");

            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // using a for loop to increment by multiples of 5
            Console.WriteLine("Count up by multiples of 5");

            for (int i = 5; i < 1000; i *= 5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // using a foreach loop with integers
            Console.WriteLine("foeach over an array of integers");

            int[] arrInts = new int[] { 1, 2, 3, 4, 5 };
            foreach (int number in arrInts)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // using a for each loop with strings
            Console.WriteLine("foreach over an array of strings");

            string[] arrStrings = new string[] { "First", "Second", "Third", "Fourth", "Fifth" };
            foreach (string text in arrStrings)
            {
                Console.WriteLine(text);
            }
            Console.WriteLine();

            // using a while loop
            int whileCounter = 0;

            Console.WriteLine("Counting up by one using a while loop");
            while (whileCounter < 10)
            {
                Console.WriteLine(whileCounter);
                whileCounter++;
            }
            Console.WriteLine();

            // using a do-while loop
            int doCounter = 0;

            Console.WriteLine("Counting up using a do-while loop");
            do
            {
                Console.WriteLine(doCounter);
                doCounter++;
            } while (doCounter < 10);
            Console.WriteLine();

        }
    }
}
