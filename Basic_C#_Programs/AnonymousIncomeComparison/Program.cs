using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Starts Program by printing what's in parentheses to the console.
            Console.WriteLine("Anonymous Income Comparison Program");
            // Prints Person 1 to console.
            Console.WriteLine("Person 1");
            // Prints Hourly Rate? to console.
            Console.WriteLine("Hourly Rate?");
            // assigns an integer value to the variable Hourly of 25
            int Hourly = 25;
            //Prints that variable to console
            Console.WriteLine(Hourly);
            //Prints Hours worked per week? to console.
            Console.WriteLine("Hours worked per week?");
            // assigns an integer value to the variable hoursPerWeek of 45
            int hoursPerWeek = 45;
            //Prints the variable to console
            Console.WriteLine(hoursPerWeek);

            // Prints Person 2 to console.
            Console.WriteLine("Person 2");
            // Prints Hourly Rate? to console.
            Console.WriteLine("Hourly Rate?");
            // assigns an integer value to the variable hourRate of 45
            int hourRate = 45;
            //Prints that variable to console
            Console.WriteLine(hourRate);
            //Prints Hours worked per week? to console.
            Console.WriteLine("Hours worked per week?");
            // assigns an integer value to the variable hoursWeek of 35
            int hoursWeek = 35;
            //Prints the variable to console
            Console.WriteLine(hoursWeek);

            // Prints Annual Salary of Person 1: to console
            Console.WriteLine("Annual Salary of Person 1:");
            //takes the hourly variable and the hoursPerWeek variable multiplies it by 52, the number of weeks in a year.
            int Person1 = Hourly * hoursPerWeek * 52;
            //prints Person1 variable to console.
            Console.WriteLine(Person1);

            // Prints Annual Salary of Person 1: to console
            Console.WriteLine("Annual Salary of Person 2:");
            //takes the hourRate variable and the hoursWeek variable multiplies it by 52, the number of weeks in a year.
            int Person2 = hourRate * hoursWeek * 52;
            //prints Person2 variable to console.
            Console.WriteLine(Person2);

            //Prints Does Person 1 make more money than Person 2?
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            // makes a boolean(true or false) statement comparing variables Person1 and Person2
            bool moreThan = Person1 > Person2;
            //Prints true or false answer based on variables Person1 and Person2
            Console.WriteLine(moreThan);


        }
    }
}
