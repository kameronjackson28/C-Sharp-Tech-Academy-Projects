using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //creates a string array listing the values within curly brackets to the variable "workDays"
        string[] workDays = new string[] { "Tues", "Wednesday", "Thurs", "Friday", "Saturday", "Sunday" };
        //Prints what's in the parentheses to console
        Console.WriteLine("Choose an index number 0-5");
        //assigns user input as an integer value to variable "WorkDays1"
        int workDays1 = Convert.ToInt32(Console.ReadLine());
        //takes data from the user input to give the index of the array
        Console.WriteLine(workDays[workDays1]);


        //assigns a number array listing the values within the curly brackets to the variable "numbers"
        int[] numbers = new int[] { 5, 6, 8, 10, 200 };
        //prints what's in the parentheses to console.
        Console.WriteLine("Choose an index number 0-4");
        //assigns user input as an integer value to variable "numbers1"
        int numbers1 = Convert.ToInt32(Console.ReadLine());

        //uses boolean statement to check if the number five is greater than user's input and if user's input is greater than or equal to 0 assigned to variable v
        bool v = Convert.ToBoolean(numbers1 < 5 && numbers1>=0);

        //creates the beginning of an if else statement using the earlier defined boolean statement assigned to variable v
        if (v)
        {
            //if the boolean statement is true, the statement below takes data from user's input to give the index of the array
            Console.WriteLine(numbers[numbers1]);

            //prints what's in parentheses to console
            Console.WriteLine("Please choose a number between 0-6");

            //creates a new list and adds to the list user stringList.Add
            List<string> stringList = new List<string>();
            stringList.Add("A");
            stringList.Add("Shrimp's");
            stringList.Add("heart");
            stringList.Add("is");
            stringList.Add("in");
            stringList.Add("it's");
            stringList.Add("head");

            //assigns user's input as value for the variable stringList1
            int stringList1 = Convert.ToInt32(Console.ReadLine());

            //takes data from user's input to give the chosen index of the array
            Console.WriteLine(stringList[stringList1]);
        }
        //uses condition statement to follow through with the earlier used boolean
        else
        {
            //if statement is "false", it will produce the error message in parentheses.
            Console.WriteLine("Error, Please choose number between 0-4");


        }

    }
}

