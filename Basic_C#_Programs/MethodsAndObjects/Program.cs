using System;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //prints what's in parentheses to screen
            Console.WriteLine("Welcome to the Method and Objects Program");

            //instantiates Employee class
            Employee employee = new Employee();
            //initializes Employee Object declaring first name value
            employee.firstName = ("Sample");
            //initializes Employee Object declaring last name value
            employee.lastName = ("Student");
            //calls the superclass method SayName() on the employee object
            employee.SayName();

        }
    }
}
