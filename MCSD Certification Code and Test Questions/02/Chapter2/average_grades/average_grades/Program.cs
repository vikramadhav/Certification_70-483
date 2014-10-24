using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average_grades
{
    class Program
    {
        static void Main(string[] args)
        {
            // foreach loop to average grades in an array
            // set up an integer array and assign some values
            int[] arrGrades = new int[] { 78, 89, 90, 76, 98, 65 };

            // create three variables to hold the sum, number of grades, and the average
            int total = 0;
            int gradeCount = 0;
            double average = 0.0;

            // loop to iterate over each integer value in the array
            // foreach doesn’t need to know the size initially as it is determined
            // at the time the array is accessed. 
            foreach (int grade in arrGrades)
            {
                total = total + grade; // add each grade value to total
                gradeCount++;          // increment counter for use in average
            }

            average = total / gradeCount;   // calculate average of grades
            Console.WriteLine(average);

        }
    }
}
