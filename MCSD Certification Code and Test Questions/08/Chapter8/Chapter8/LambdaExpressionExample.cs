using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8
{
    class LambdaExpressionExample
    {
        delegate void MyFirstDelegate(string s);
        delegate void MyAnonymousMethod();
        delegate double square(double x);
        delegate bool GreaterThan(double x, double y);

        static void Main(string[] args)
        {
            square myLambdaExpression = x => x * x;

            Console.WriteLine("X squared is {0}", myLambdaExpression(5));

            GreaterThan gt = (x, y) => x > y;
            Console.WriteLine("Is 6 greater than 5. {0}", gt(6, 5));

            string myLocalString = "Hello World";

            //Call the function the normal way.           
            WriteToConsoleForward(myLocalString);
            WriteToConsoleBackwards(myLocalString);

            //Call the function using a delegate.                       
            MyFirstDelegate myFirstDelegate = new MyFirstDelegate(LambdaExpressionExample.WriteToConsoleForward);
            myFirstDelegate(myLocalString);

            //Call the fuction by passing a reference to the function.            
            WriteToConsole(LambdaExpressionExample.WriteToConsoleForward, myLocalString);
            WriteToConsole(LambdaExpressionExample.WriteToConsoleBackwards, myLocalString);

            //Create an anonymous method using the local variable.
            MyAnonymousMethod forward = delegate()
            {
                Console.WriteLine(string.Format("This is my string: {0}", myLocalString));
            };
            forward();

            //Create an anonymous method with the original delegate.           
            MyFirstDelegate backward = delegate(string s2)
            {
                char[] charArray = s2.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(string.Format("This is my string backwards: {0}", new string(charArray)));
            };
            backward(myLocalString);

            //Use a Lambda expression statement with a local variable.
            MyAnonymousMethod myFirstDelegate2 = () =>
            {
                char[] charArray = myLocalString.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(string.Format("This is my string backwards: {0}", new string(charArray)));
            };
            myFirstDelegate2();

            //Use a Lambda expression statement with a parameter.
            MyFirstDelegate myFirstDelegate3 = s =>
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(string.Format("This is my string backwards: {0}", new string(charArray)));
            };
            myFirstDelegate3(myLocalString);

            WriteToConsole(x => Console.WriteLine("This is my string {0}", x), "Hello World");
            
            Console.ReadLine();
        }

        static void WriteToConsoleForward(string stringToWrite)
        {
            Console.WriteLine(string.Format("This is my string: {0}", stringToWrite));
        }

        static void WriteToConsoleBackwards(string stringToWrite)
        {
            char[] charArray = stringToWrite.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine(string.Format("This is my string to write backwards: {0}", new string(charArray)));
        }

        static void WriteToConsole(MyFirstDelegate myDelegate, string stringToWrite)
        {
            myDelegate(stringToWrite);
        }
    }
}
