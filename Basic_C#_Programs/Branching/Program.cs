using System;

namespace Branching
{
    class Program
    {
        static void Main()
        {
            //Prints what's in parentheses to console.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //asks user for weight of package
            Console.WriteLine("What is the weight of the package?");
            //assigns value of 50 to weight variable
            int weight = 50;
            //assigns value of user's input to userweight variable.
            int userweight = Convert.ToInt32(Console.ReadLine());
            //creates an if statement comparing weight and user weight.
            if (weight < userweight)
            {
                //prints what's in the parentheses to console, ends program.
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
             
            }
            //according to "if" statement, if variable userweight is not greater than variable weight it moves to the else statement.
            else
            {
                //
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Please enter the package height");


                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());
                int dimensions = length + width + height;
                int correctdim = 50;

                if (dimensions > correctdim)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();

                }
                else
                {
                    decimal total = Convert.ToDecimal(length * width * height * userweight);
                    decimal total1 = total / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: "+ "$" + total1);
                }





            }

        }
    }
}

