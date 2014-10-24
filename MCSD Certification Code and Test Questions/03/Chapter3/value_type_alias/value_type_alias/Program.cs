using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace value_type_alias
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a variable to hold a value type using the alias form
            // but don’t assign a variable
            int myInt;
            int myNewInt = new int();

            // create a variable to hold a .NET value type
            // this type is the .NET version of the alias form int
            // note the use of the keyword new, we are creating an object from 
            // the System.Int32 class
            System.Int32 myInt32 = new System.Int32();

            // you will need to comment out this first Console.WriteLine statement
            // as Visual Studio will generate an error about using an unassigned
            // variable.  This is to prevent using a value that was stored in the
            // memory location prior to the creation of this variable
            Console.WriteLine(myInt);

            // print out the default value assigned to an int variable
            // that had no value assigned previously
            Console.WriteLine(myNewInt);

            // this statement will work fine and will print out the default value for
            // this type, which in this case is 0
            Console.WriteLine(myInt32);

        }
    }
}
