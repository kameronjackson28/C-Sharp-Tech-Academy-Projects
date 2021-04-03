using System;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            mathOperation math = new mathOperation();
            int x = 7;

            int sum = mathOperation.myMath(x);

            Console.WriteLine(sum);


            mathOperation multiply = new mathOperation();
            decimal y = decimal.Round(6.7m);
           

            decimal myMultiply = mathOperation.myMath(y);

            Console.WriteLine(myMultiply);
        }
    }
}
