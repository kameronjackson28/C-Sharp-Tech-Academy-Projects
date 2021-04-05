using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //prints what's in parentheses to screen
            Console.WriteLine("Welcome to the Abstract Class Program");

            //instantiates Employee class
            Employee employee = new Employee();
            //assigns sample to employee firstName
            employee.firstName = "Sample ";
            //assigns student to employee lastName
            employee.lastName = "Student";

            //Calls teh SayName method
            employee.SayName();
        }
    }
}
