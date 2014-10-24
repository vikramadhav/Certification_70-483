using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading_constructors
{
    class studentStudent
    {
        public string firstName;
        public string lastName;
        public int grade;
        public string schoolName;

        public studentStudent()
        {
        }

        public studentStudent(string first, string last)
        {
            this.firstName = first;
            this.lastName = last;
        }

        public studentStudent(string first, string last, int grade, string school)
        {
            this.firstName = first;
            this.lastName = last;
            this.grade = grade;
            this.schoolName = school;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            studentStudent studentStudent1 = new studentStudent();

            studentStudent studentStudent2 = new studentStudent("Tom", "Jones");

            studentStudent studentStudent3 = new studentStudent("Mike", "Myers", 5, "My School");

        }
    }

}
