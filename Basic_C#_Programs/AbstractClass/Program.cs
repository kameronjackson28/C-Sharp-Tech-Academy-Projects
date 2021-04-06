using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //uses polymorphism to create new Iquittable object
            IQuittable quit = new Employee();
            
            //prints what's in parentheses to screen
            Console.WriteLine("Welcome to the Abstract Class Program");

            //instantiates Employee class
            Employee employee1 = new Employee();
            //assigns sample to employee firstName
            employee1.firstName = "Sample ";
            //assigns student to employee lastName
            employee1.lastName = "Student";

            employee1.iD = 90210;

            Employee employee2 = new Employee();
            employee2.firstName = "Sally";
            employee2.lastName = "Seashore";
            employee2.iD = 54321;

            ////Calls teh SayName method
            //employee.SayName();

            ////calls quit method on quit object
            //quit.Quit();
        }
    }
}
