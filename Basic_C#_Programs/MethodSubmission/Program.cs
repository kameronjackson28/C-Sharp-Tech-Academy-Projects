using System;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints what's written in parentheses to console
            Console.WriteLine("Welcome to the beginning of the program");
            //instantiates class "Data"
            Data data = new Data();

            //Asks user to input a number
            Console.WriteLine("Please input a number.");
            //converts user input to an integer and assigns it to variable y
            int y = Convert.ToInt32(Console.ReadLine());
            //prints what's written in parentheses to console
            Console.WriteLine("If you want to, input another number. If not, just press Enter.");
            //assigns user input as a value to zStr variable
            string zStr = Console.ReadLine();

            //creates if statement comparing variable zStr to no input
            if (zStr == "")
            {
                //assigns the y variable within the mathOp method creating integer variable sum
                int sum = Data.mathOp(y);
                //if zStr = blank result + sum is printed to console only calling variable y
                Console.WriteLine("Result: " + sum);
            }
            //states if conditon in if statement is not true else statement will take place
            else
            {
                //converts zStr to integer assigns it to optional variable z
                int z = Convert.ToInt32(zStr);
                //creates variable sum using method mathOp calling y and z parameters
                int sum = Data.mathOp(y, z);
                //prints to console result plus sum
                Console.WriteLine("Result: " + sum);
            }
            //keeps program open so that it's viewable to user.
            Console.ReadLine();
            
        }
    }
}
