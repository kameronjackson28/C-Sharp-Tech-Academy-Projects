using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Constructors
{
    class Employee
    { 
        //uses "this" statement to chain this constructor with the latter
        public Employee(string name) : this(name, 1234, "new hire")
        {
            
        }
        
        //creates constructor Employee assigning it parameters of name, id, and department
        public Employee(string name, int id, string department)
        {
            //assigns value to name variable
            name = "Kameron";
            //assigns value to department variable.
            department = "Collections";
        }
        
    }
}
