using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    //creates Employee class inheriting from Person class
    public class Employee : Person, IQuittable
    {

        public int iD { get; set; }
        //implements SayName method in class
        public override void SayName()
        {
            //writes person's full name to console when SayName method is called
            Console.WriteLine("Name: " + firstName + lastName);
        }

        //implements Quit method from IQuittable 
        public void Quit()
        {
            //prints what's in parentheses to screen
            Console.WriteLine("Employee has quit");
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.iD == employee2.iD;

        }

        public static bool operator != (Employee employee1, Employee employee2)
        {
            return employee1.iD != employee2.iD;
        }
        
        
    
    }
}
