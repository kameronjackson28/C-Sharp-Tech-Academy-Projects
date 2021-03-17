using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //gives opening headline
            Console.WriteLine("The Tech Academy\nStudent Daily Report");
            //prints question asked "What is your name?"
            Console.WriteLine("What is your name?");
            //takes input from user 
            string yourName = Console.ReadLine();
            //prints question 
            Console.WriteLine("What course are you on?");
            //takes input from user stores it as string data
            string course = Console.ReadLine();
            //takes question asked prints to console
            Console.WriteLine("What page number?");
            // takes only integer value from user
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            // asks question to console
            Console.WriteLine("Do you need help with anything? Please answer\" True\" or \"False");
            //takes only true or false input from user
            Convert.ToBoolean(Console.ReadLine());
           
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            //takes string input from user saves data as string
            string experiences = Console.ReadLine();
            //Asks question prints to console.
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            // saves string input from user
            string feedback = Console.ReadLine();
            //Asks question prints to console
            Console.WriteLine("How many hours did you study today?");
            //takes integer answer only saves data
            int hoursStudied = Convert.ToInt32(Console.ReadLine());
            //Takes last line and closes program
            Console.WriteLine("Thank you for all of your answers. An Instructor will respond to this shortly. Have a great day!");

        }
    }
}
