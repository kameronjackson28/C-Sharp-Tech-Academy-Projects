using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndObjects
{
    //creates public class Person
    public class Person
    {
        //Gives 1 of 2 properties name firstName
        public string firstName { get; set; }
        //Gives 2nd property name lastName
        public string lastName { get; set; }

        //creates SayName method
        public void SayName()
        {
            //writes person's full name to console when SayName method is called
            Console.WriteLine("Name: " + firstName + lastName);
        }

    }
}
