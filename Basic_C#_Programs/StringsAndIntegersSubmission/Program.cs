using System;
using System.Collections.Generic;

namespace StringsAndIntegersSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = new List<int>() { 5, 3, 2, 6, 10 };
            Console.WriteLine("Please enter a number to divide by:");
            int user = Convert.ToInt32(Console.ReadLine());
            
           foreach( int n in first)
            {
                int test = n / user;
                Console.WriteLine(test);
                
            }

        }
    }
}
