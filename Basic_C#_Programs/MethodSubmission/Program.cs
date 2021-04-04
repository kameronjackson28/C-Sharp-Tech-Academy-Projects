using System;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the beginning of the program");
            Data data = new Data();

            Console.WriteLine("Please input two numbers, one at a time.");

            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            int sum = Data.mathOp(y, z);

            
       

            Console.WriteLine(sum);
            Console.ReadLine();
            
        }
    }
}
