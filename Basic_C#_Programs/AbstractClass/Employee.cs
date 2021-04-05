using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    //creates Employee class inheriting from Person class
    public class Employee : Person
    {
        //implements SayName method in class
        public override void SayName()
        {
            base.SayName();
        }
    }
}
