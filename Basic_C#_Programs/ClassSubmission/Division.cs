using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSubmission
{
    class Division
    {
        //creates a void method named mathDivide using int i as parameter
        public void mathDivide(int i)
        {
            
            //assigns i / 2 as value to result variable.
            int result = i / 2;
            //prints variable result to console.
            Console.WriteLine(result);
        }

        //creates void method mathMultiply using out int x as a parameter
        public void mathMultiply(out int x)
        {
            //assigns 5 to variable x
            x = 5;
            // assigns math equation x * 25 to variable secondResult
            int secondResult = x * 25;
            //prints secondResult to console.
            Console.WriteLine("Here is your result " + secondResult);
        }

        //creates static method myMath using an int as the parameter
        public static int myMath(int l)
        {
            //returns l * 6
            return (l * 6);
        }

        //creates another myMath method(method overloading) using a string as the parameter
        public static int myMath( string z)
        {
           //assigns string as an integer by converting said string to an integer giving it the variable name of a
            int a = Convert.ToInt32(z);
            //returns a * 7
            return (a * 7);

          
        }
    }
}
