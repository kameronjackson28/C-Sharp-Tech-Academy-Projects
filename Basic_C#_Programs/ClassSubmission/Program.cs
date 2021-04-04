using System;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints what's in parentheses to screen
            Console.WriteLine("Hello, Welcome to the Class Submission Program");

            //instantiates Division class 
            Division division = new Division();

            //Asks user to enter a number
            Console.WriteLine("Please enter a number");
            //converts user input to int assigning that value to int variable "i"
            int i = Convert.ToInt32(Console.ReadLine());

            //calls the mathDivide method using parameter "i"
            division.mathDivide(i);
            //allows program to stay open for a second before moving to next item.
            Console.ReadLine();

            //declares local variable x whose value has already been assigned in it's method
            int x;
            //calls mathMultiply method using out parameter x
            division.mathMultiply(out x);

          
            //assigns called method using 55 as parameter to variable sum
            int sum = Division.myMath(55);
            //prints variable sum to screen
            Console.WriteLine(sum);

            //assigns called method myMath assigning "7" as parameter to variable total
            int total = Division.myMath("7");
            //prints variable total to screen
            Console.WriteLine(total);

            //makes user press a key before program goes away.
            Console.ReadLine();
        }
    }
}
