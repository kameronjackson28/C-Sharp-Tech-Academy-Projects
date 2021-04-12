using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DT
{
    class Program
    {
        static void Main(string[] args)
        {
            //prints what's in parentheses to console.
            Console.WriteLine("Please enter a number");
            //creates int variable user assigning user input as the value
            int user = Convert.ToInt32(Console.ReadLine());
            //prints int variable user to screen
            Console.WriteLine(user);
            //uses DateTime.Now to print time when user inputs to screen.
            Console.WriteLine(DateTime.Now);
            
        }
    }
}
