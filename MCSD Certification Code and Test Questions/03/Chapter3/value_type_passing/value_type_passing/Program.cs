using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace value_type_passing
{
    class studentStudent
    {
        public string firstName;
        public string lastName;
        public string grade;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 3;
            int result;

            studentStudent firstStudentStudent = new studentStudent();

            firstStudentStudent.firstName = "John";
            firstStudentStudent.lastName = "Smith";
            firstStudentStudent.grade = "six";

            result = sum(num1, num2);
            Console.Write("Sum is: ");
            Console.WriteLine(result);  // outputs 5
            Console.WriteLine();

            changeValues(num1, num2);
            Console.WriteLine();
            Console.WriteLine("Back from changeValues()");
            Console.WriteLine(num1);  // outputs 2
            Console.WriteLine(num2);  // outputs 3

            Console.WriteLine();
            Console.WriteLine("First name for firstStudentStudent is " + firstStudentStudent.firstName);
            changeName(firstStudentStudent);
            Console.WriteLine();
            Console.WriteLine("First name for firstStudentStudent is " + firstStudentStudent.firstName);

        }

        static int sum(int value1, int value2)
        {
            Console.WriteLine("In method sum()");
            return value1 + value2;
        }

        static void changeValues(int value1, int value2)
        {
            Console.WriteLine("In changeValues()");
            Console.WriteLine("value1 is " + value1);  // outputs 2
            Console.WriteLine("value2 is " + value2);  // outputs 3
            Console.WriteLine();
            Console.WriteLine("Changing values");

            value1--;
            value2 += 5;

            Console.WriteLine();
            Console.WriteLine("value1 is now " + value1);  // outputs 1
            Console.WriteLine("value2 is now " + value2);  // outputs 8
        }

        static void changeName(studentStudent refValue)
        {
            Console.WriteLine();
            Console.WriteLine("In changeName()");
            refValue.firstName = "George";
        }
    }

}
