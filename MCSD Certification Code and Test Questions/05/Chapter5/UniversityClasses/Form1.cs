using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TeachingAssistant ta = new TeachingAssistant();
            TeachingAssistant4 ta = new TeachingAssistant4();

            // The following causes a design time error for the
            // TeachingAssistant4 class but not the TeachingAssistant class.
            ta.PrintGrades();

            // The following does work.
            IStudent student = ta;
            student.PrintGrades();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public interface IStudent
    {
        // The student's list of current courses.
        List<string> Courses { get; set; }

        // Print the student's current grades.
        void PrintGrades();
    }

    public class Student : Person, IStudent
    {
        // Implement IStudent.Courses.
        // The student's list of current courses.
        public List<string> Courses { get; set; }

        // Implement IStudent.PrintGrades.
        // Print the student's current grades.
        public void PrintGrades()
        {
            // Do whatever is necessary...
            Console.WriteLine("Student.PrintGrades");
        }
    }

    public class Employee : Person
    {
        public int EmployeeId { get; set; }
    }

    public class Faculty : Employee
    {
        private List<string> _CoursesTaught = new List<string>();
        public List<string> CoursesTaught
        {
            get { return _CoursesTaught; }
            set { _CoursesTaught = value; }
        }
    }

    public class Staff : Employee
    {
        public int Shift { get; set; }
    }

    public class TeachingAssistant : Faculty, IStudent
    {
        // Implement IStudent.Courses.
        // The student's list of current courses.
        public List<string> Courses { get; set; }

        // Implement IStudent.PrintGrades.
        // Print the student's current grades.
        public void PrintGrades()
        {
            // Do whatever is necessary...
            Console.WriteLine("TeachingAssistant.PrintGrades");
        }
    }

    // Delegate IStudent to a Student object.
    public class TeachingAssistant2 : Faculty, IStudent
    {
        // A Student object to handle IStudent.
        private Student MyStudent = new Student();

        #region IStudent Members

        public List<string> Courses
        {
            get
            {
                return MyStudent.Courses;
            }
            set
            {
                MyStudent.Courses = value;
            }
        }

        public void PrintGrades()
        {
            MyStudent.PrintGrades();
        }

        #endregion
    }

    // Implicit implementation.
    public class TeachingAssistant3 : Faculty, IStudent
    {
        #region IStudent Members

        public List<string> Courses
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void PrintGrades()
        {
            Console.WriteLine("TeachingAssistant3.PrintGrades");
        }

        #endregion
    }

    // Explicit implementation.
    public class TeachingAssistant4 : Faculty, IStudent
    {
        #region IStudent Members

        List<string> IStudent.Courses
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        void IStudent.PrintGrades()
        {
            Console.WriteLine("TeachingAssistant4.IStudent.PrintGrades");
        }

        #endregion
    }
}
