using System;

namespace WhileDoWhile
{
    class Program
    {
        static void Main()
        {
            //creates variable firstnum with the value of ten 
            int firstnum = 10;
            //using while loop with the comparison of 10 greater or equal to 20.
            while(firstnum <= 20)
            {
                //prints variable firstnum(which is 10) to console.
                Console.WriteLine(firstnum);
                firstnum++; // increment
            }

            //creates variable secondnum with the value of 20
            int secondnum = 20;
            //starts the "do" statement.
            do
            {
                //creates a statement
                Console.WriteLine(secondnum);
                secondnum++;
            }
            //creates the condition in this case comparing secondnum(20) to 21
            while (secondnum < 21);
            
        }
    }
}
