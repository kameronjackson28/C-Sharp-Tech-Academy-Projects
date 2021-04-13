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
            //uses DateTime.Now to print time to screen.
            Console.WriteLine(DateTime.Now);
            //prints what's in parentheses to console.
            Console.WriteLine("Please enter a number");
            //creates int variable user assigning user input as the value
             int user = Convert.ToInt32(Console.ReadLine());
            //prints to console time now plus user input added to time now.
            Console.WriteLine(DateTime.Now.AddHours(user));
            
        }
    }
}
