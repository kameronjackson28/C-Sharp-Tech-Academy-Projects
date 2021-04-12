using System;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //prints what's in parentheses to screen
            Console.WriteLine("Please input a number");
            //assigns user input as string variable user
            string user = Console.ReadLine();
            //copies text to file path described using user variable as the argument.
            File.WriteAllText(@"C:\\Users\\Kameron Jackson\\OneDrive\\Documents\\GitHub\\C-Sharp-Tech-Academy-Projects\\Basic_C#_Programs\\input.txt", user);

            //prints user to screen.
            Console.WriteLine(user);
        }
    }
}
