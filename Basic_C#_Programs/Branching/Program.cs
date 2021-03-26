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
                //prints what's in parenthese to console
                Console.WriteLine("Please enter the package width:");
                //assigns int width variable of user's input
                int width = Convert.ToInt32(Console.ReadLine());

                //prints what's in parenthese to console
                Console.WriteLine("Please enter the package height");
                //assigns integer variable to user's input
                int height = Convert.ToInt32(Console.ReadLine());
                //prints what's in parenthese to console
                Console.WriteLine("Please enter the package length:");
                //assigns int variable to user's input 
                int length = Convert.ToInt32(Console.ReadLine());
                //adds variables length, width, and height assigning it to a new variable
                int dimensions = length + width + height;
                //assigns the number 50 as correctdim variable.
                int correctdim = 50;
                //creates an if statement comparing dimensions and correct dimensions
                if (dimensions > correctdim)
                {
                    //prints what's in parenthese to console
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    

                }
                //according to "if" statement, if variable correctdim is not greater than variable dimensions it moves to the else statement.
                else
                {
                    //assigns length * width * height * userweight to decimal variable total
                    decimal total = Convert.ToDecimal(length * width * height * userweight);
                    //takes the decimal variable total and divides it by 100 creating new variable total1
                    decimal total1 = total / 100;
                    //concatenates "Your estimated total for shipping this package is: " with a "$" finally, with variabel total1
                    Console.WriteLine("Your estimated total for shipping this package is: "+ "$" + total1);
                }





            }

        }
    }
}

