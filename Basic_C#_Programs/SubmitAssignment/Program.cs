using System;
using System.Collections.Generic;

class Program
    {
    static void Main()
    {
        string[] first = new string[] { "One", "Two", "Three", "Four" };
        Console.WriteLine("Enter text to add to string:");
        string add = Console.ReadLine();
        for (int s = 0; s < first.Length; s++)
        {
            first[s] = first[s] + add;

            Console.WriteLine(first[s]);
        }



        int one = 0;

        while (true)
        {
            Console.WriteLine("Count = {0}", one);
            one++;

            if (one > 5)
            {
                break;
            }
        }




        int firstnum = 25;
        do
        {
            Console.WriteLine(firstnum);
            firstnum++;
        }

        while (firstnum < 30);
        {

        }




        int secondnum = 15;
        while (secondnum <= 30)
        {
            Console.WriteLine("Count = {0}", secondnum);
            secondnum++;
        }



        List<string> newString = new List<string>() {"Kinsey", "Claire", "Jacobi", "Jill", "Yuki", "Cindy"};
        Console.WriteLine("Enter search keyword(s) or letter(s) here:");
        

        foreach(string k in newString)
        {
            string search = Console.ReadLine();
            if (k == search)
            {
                Console.WriteLine("Here are your results: " );
            }
        }



    }
    }

