using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    //creates abstract class Person
    public abstract class Person
    {
        //Gives string property of firstName
        public string firstName { get; set; }
        //Gives string property of lastName
        public string lastName { get; set; }

        //creates SayName method
        public virtual void SayName()
        {
            //writes person's full name to console when SayName method is called
            Console.WriteLine("Name: " + firstName  + lastName);
        }

    }
}
