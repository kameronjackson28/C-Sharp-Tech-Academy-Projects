using System;

namespace CarInsurance
{
    class Program
    {
       

        static void Main(string[] args)
        {
            //prints What is your age? to console.
            Console.WriteLine("What is your age?");
            //assigns user's input as a value to variable age
            int age = Convert.ToInt32(Console.ReadLine());

            //prints Have you ever had a DUI? to console.
            Console.WriteLine("Have you ever had a DUI?");
            // assigns user input as a boolean value to the variable dui
            bool dui = Convert.ToBoolean(Console.ReadLine());

            // prints How many speeding tickets do you have? to console.
            Console.WriteLine("How many speeding tickets do you have?");
            //assigns user input as a integer value to the variable speedingTicket
            int speedingTicket = Convert.ToInt32(Console.ReadLine());

            //prints Qualified? to console.
            Console.WriteLine("Qualified?");
            //assigns the min age integer value to variable qualified
            int qualified = Convert.ToInt32(15);
            //assigns false value to the boolean variable qdui
            bool qdui = false;
            //assigns integer value 3 to the variable qspeeding ticket
            int qspeedingticket = Convert.ToInt32(3);
            //makes a boolean equation comparing all of the values for the qualifications. 
            bool qualifications = age >= qualified && dui == qdui && speedingTicket < qspeedingticket;
            //takes the equation and prints to console.
            Console.WriteLine(qualifications);
            

        }
    }
}
