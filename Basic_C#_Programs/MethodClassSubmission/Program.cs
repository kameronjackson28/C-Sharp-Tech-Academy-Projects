using System;

namespace MethodClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //prints what's in parentheses to screen
            Console.WriteLine("Hello, welcome to the beginning of the program");

            //instantiates Math class
            Math math = new Math();

            //calls the method in the class passing in two numbers
            math.myMath(4, 7);

            //assigns value to the parameter variables
            int firstNum = 4;
            int secondNum = 7;
            //calls the method in the class specifying the parameters by name
            math.myMath(firstNum, secondNum);
            
        }
    }
}
