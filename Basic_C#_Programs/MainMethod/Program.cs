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
            decimal y = 6.79m;
            //assigns method myMath as a decimal variable incorporating variable y
            decimal myMultiply = mathOperation.myMath(y);
            //prints the variable myMultiply to console.
            Console.WriteLine(myMultiply);

            //instantiates mathOperation class 
            mathOperation convert = new mathOperation();
            //assigns 5 as the string variable z
            string z = "5";
            //assigns method myMath as an int variable of myConvert introducing variable z.
            int myConvert = mathOperation.myMath(z);
            //prints variable myConvert to console.
            Console.WriteLine(myConvert);


        }
    }
}
