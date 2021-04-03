using System;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates mathOperation class
            mathOperation math = new mathOperation();
            //assigns an integer to the variable x
            int x = 7;
            //assigns the method myMath as an integer incorporating variable x
            int sum = mathOperation.myMath(x);
            //prints variable sum to the console
            Console.WriteLine(sum);


            //instantiates mathOperation class again under new variable name
            mathOperation multiply = new mathOperation();
            //assigns a decimal value to the variable y and
            //uses the built in decimal.Round method to convert the decmial to an integer
            decimal y = decimal.Round(6.7m);
            //assigns method myMath as a decimal variable incorporating variable y
            decimal myMultiply = mathOperation.myMath(y);
            //prints the variable myMultiply to console.
            Console.WriteLine(myMultiply);


            mathOperation convert = new mathOperation();

            string i = "five";

            string myConvert = mathOperation.myMath(i);


        }
    }
}
