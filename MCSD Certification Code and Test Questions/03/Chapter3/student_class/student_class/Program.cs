using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_class
{
    // create a class called Student
    class Student
    {
        public static int StudentCount;
        public string firstName;
        public string lastName;
        public string grade;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student();
            Student.StudentCount++;
            Student secondStudent = new Student();
            Student.StudentCount++;

            firstStudent.firstName = "John";
            firstStudent.lastName = "Smith";
            firstStudent.grade = "six";

            secondStudent.firstName = "Tom";
            secondStudent.lastName = "Thumb";
            secondStudent.grade = "two";

            Console.WriteLine(firstStudent.firstName);
            Console.WriteLine(secondStudent.firstName);
            Console.WriteLine(Student.StudentCount);
        }
    }

}
