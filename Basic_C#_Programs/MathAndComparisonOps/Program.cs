using System;

namespace MathAndComparisonOps
{
    class Program
    { 

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to multiply by 50");
            // Creates a variable allowing user to input number
            int user_Num = Convert.ToInt32(Console.ReadLine());
            // takes that variable and multiplies it by 50
            Console.WriteLine(user_Num * 50);
           

            Console.WriteLine("Enter a number to add to 25");
            // Creates a variable allowing user to input number
            int add_Num = Convert.ToInt32(Console.ReadLine());
            // Takes that number and adds 25
            Console.WriteLine(add_Num + 25);
        

            Console.WriteLine("Enter a number to check if it is greater than 50");
            // Creates a variable allowing user to input number
            int greaterThan = Convert.ToInt32(Console.ReadLine());
            // Creates a boolean statement to check if the user input is greater than 50
            bool great = greaterThan > 50;
            // Prints the true or false result to the console.
            Console.WriteLine(greaterThan  > 50);

            Console.WriteLine("Enter a number to divide by 7");
            // Creates a variable allowing user to input number
            int remainder = Convert.ToInt32(Console.ReadLine());
            // Takes the user's input and prints the remainder to the console.
            Console.WriteLine(remainder % 7);




        }
    }
}
