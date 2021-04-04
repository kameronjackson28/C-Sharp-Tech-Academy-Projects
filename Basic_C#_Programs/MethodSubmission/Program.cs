using System;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the beginning of the program");
            Data data = new Data();

            Console.WriteLine("Please input a number.");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If you want to, input another number. If not, just press Enter.");
            string zStr = Console.ReadLine();

            if (zStr == "")
            {
                int sum = Data.mathOp(y);
                Console.WriteLine("Result: " + sum);
            }
            else
            {
                int z = Convert.ToInt32(zStr);
                int sum = Data.mathOp(y, z);
                Console.WriteLine("Result: " + sum);
            }
            Console.ReadLine();
            
        }
    }
}
