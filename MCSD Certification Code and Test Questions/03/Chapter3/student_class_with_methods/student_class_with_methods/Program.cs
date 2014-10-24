using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_class_with_methods
{
    class Student
    {
        public static int StudentCount;
        public string firstName;
        public string lastName;
        public string grade;

        public string concatenateName()
        {
            string fullName = this.firstName + " " + this.lastName;
            return fullName;
        }

        public void displayName()
        {
            string name = concatenateName();
            Console.WriteLine(name);
        }
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

            firstStudent.displayName();
        }
    }

}
