using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates try block
            try
            {
                //prints what's in parentheses to screen
                Console.WriteLine("Enter the current day of the week");
                //takes in user input as value to string variable user
                string user = Console.ReadLine();

                //converts user input to Enum, making it limited to values of the enum
                DayOfWeek dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), user);
                //prints what's in parentheses to the screen
                Console.WriteLine("The day of the week is: " + dayOfWeek);
                //Keeps console open until user presses a button
                Console.ReadLine();
            }
            //creates catch block with generic exception as parameter
            catch (Exception)
            {
                //print's what's in parentheses to console.
                Console.WriteLine("Please enter an actual day of the week");
                //keeps console open until usre presses a button
                Console.ReadLine();
            }
        }
    }
}

