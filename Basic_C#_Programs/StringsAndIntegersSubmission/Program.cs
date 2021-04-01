using System;
using System.Collections.Generic;

namespace StringsAndIntegersSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //creates the try catch block
                try
                {
                    //creates an integer list 
                    List<int> first = new List<int>() { 5, 3, 2, 6, 10 };
                    //asks user to enter a number to divide by
                    Console.WriteLine("Please enter a number to divide by:");
                    //assigns user input to integer variable user
                    int user = Convert.ToInt32(Console.ReadLine());

                    //creates a foreach loop iterating through all in first
                    foreach (int n in first)
                    {
                        //divides user's input by each item in list
                        int test = n / user;
                        //prints the outcome to console
                        Console.WriteLine(test);

                    }
                }
                //creates a catch for format exception
                catch (FormatException ex)
                {
                    //prints what's in parentheses to console
                    Console.WriteLine("Please enter an integer and try again");
                }
                //creates a catch for dividing by zero
                catch (DivideByZeroException ex)
                {
                    //prints error message to console
                    Console.WriteLine("Please enter an integer that is not zero");
                }
                //creates a catch for any other exceptions
                catch (Exception ex)
                {
                    //prints error message to console
                    Console.WriteLine("Please check your entry and try again");
                }

                //creates a finally statement which will run with or without the exception
                finally
                {
                    //prints what's in parentheses to console.
                    Console.WriteLine("You have successfully ended the program");

                }
                  
                }
            

            }
        }
    }


