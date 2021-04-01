using System;
using System.Collections.Generic;
using System.Linq;

class Program
    {
    static void Main()
    {

        // creates an array of strings 
        string[] first = new string[] { "One", "Two", "Three", "Four" };
        //prints what's in parenthese to console
        Console.WriteLine("Enter text to add to string:");
        //assigns user input to a string variable
        string add = Console.ReadLine();
        //creates a for loop making s = 0, comparing 0 to array's length, and having the array displayed incrementally
        for (int s = 0; s < first.Length; s++)
        {
            //assigns user input to the end of each item in array
            first[s] = first[s] + add;

            //prints user input to the end of each item in the array to console.
            Console.WriteLine(first[s]);
        }
        Console.ReadLine();

        // assigns 0 to int variable one.
        int one = 0;

        //creates a while loop
        while (true)
        {
            //prints what's in parentheses onto console, incrementing the value.
            Console.WriteLine("Count = {0}", one);
            one++;

            //starts the if statement comparing 0 to 5
            if (one > 5)
            {
                //if the number increases to greater than five the program stops.
                break;
            }
        }

        Console.ReadLine();


        //assigns 25 value to int variable firstnum
        int firstnum = 25;

        //creates a do while loop
        do
        {
            //writes 25 and following numbers adding by 1
            Console.WriteLine(firstnum);
            firstnum++;
        }
        //once firstnum reaches 30 the program moves on.
        while (firstnum < 30);
        {

        }
        Console.ReadLine();



        //assigns 15 to variable secondnum
        int secondnum = 15;
        //creates a while statement comparing secondnum and 30
        while (secondnum <= 30)
        {
            //prints what's in parentheses to console, when secondnum reaches 30, program moves on.
            Console.WriteLine("Count = {0}", secondnum);
            secondnum++;
        }
        Console.ReadLine();


        //creates a list of strings.
        List<string> newString = new List<string>() {"Kinsey", "Claire", "Jacobi", "Jill", "Yuki", "Cindy"};
        //asks for user to input search keyword(s)
        Console.WriteLine("Enter search keyword(s) here:");
        //assigns user input to string variable search
        string search = Console.ReadLine();


        //creates a foreach loop iterating through all items in list
        for( int i = 0; i < newString.Count; i++)
        {
            //creates if statement comparing user's input(search) to "i".
            if (newString[i] == search)
            {
                //if results match search "Here are your results" plus the matching results are printed to console.
                Console.WriteLine("Here are your results:" + i);
                //once matching results are found, the loop ends.
                break;

            }
            //if condition is not true and there are no matching results, else statement is utilized by the program.
            else
            {
                //words in parentheses are printed to console, letting user know there is not a match.
                Console.WriteLine("Please restart program and choose a matching keyword(s), remember keywords are case sensitive.");
            }

        }
        Console.ReadLine();


        //creates a new list of strings with identical items.
        List<string> names = new List<string>() { "Abby", "Gibbs", "Dr.Mallard", "Gibbs", "Abby", "Dr.Mallard" };
        //Asks user for search keywords
        Console.WriteLine("Enter your search keyword(s) here.");
        //assigns user input as string variable isSearch
        string isSearch = Console.ReadLine();

        // creates a foreach statement iterating through the list
        for(int n = 0; n < names.Count; n++ )
        {
            //creates if statement comparing the items in the list to user's input
            if (names[n] == isSearch)
            {
                //if the user input and items on the list are a match, the console will display the results
                Console.WriteLine("Here are your results:" + n);

            }

            //otherwise it will let the user know that their input is invalid. 
            else
            {
                Console.WriteLine("Your input is invalid.");
            }       
        }
        Console.ReadLine();

        //creates a new list of strings
        List<string> newnames = new List<string>() { "Jill", "Joe", "Joe", "Jack", "Joe" };
        //creates a blank string list
        List<string> newnames1 = new List<string>();
        //creates a foreach loop iterating through each string in the list
        foreach (string name in newnames)
        {
            //creates if statement and if the blank list doesn't contain keyword 
            if(!newnames1.Contains(name))
            {
                //it adds to the blank list
                newnames1.Add(name);
                //and writes this string has not yet appeared
                Console.WriteLine("This string has not yet appeared " + name);

            }
            else
            {
                //if it is in the list, This string has already appeared prints to console.
                Console.WriteLine("This string has already appeared " + name);
                
            }
        }
        Console.ReadLine();



    }
}

