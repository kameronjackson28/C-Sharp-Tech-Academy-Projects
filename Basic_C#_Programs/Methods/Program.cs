
using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks user to input number
            Console.WriteLine("Please enter a number:");

            //assigns user input to userNum int
            int userNum = Convert.ToInt32(Console.ReadLine());

            //instantiates the Operators class
            Operators myMath = new Operators();

            //calls the add method using userNum as x
            int sum = myMath.add(userNum);
            //calls the subtract method using userNum as x
            int sum1 = myMath.subtract(userNum);
            //calls the multiply method using userNum as x 
            int remainder = myMath.multiply(userNum);
            //prints multiply method to console.
            Console.WriteLine(remainder);
            //prints the add method to console.
            Console.WriteLine(sum);
            //prints the subtract method to console.
            Console.WriteLine(sum1);

            Console.ReadLine();

            






        }
    }
}
