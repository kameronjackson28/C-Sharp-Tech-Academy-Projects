using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            //creates new list type being Employee from the Employee Class
            List<Employee> employee = new List<Employee>();
            //Creates another new list type being Employee from Employee Class.
            List<Employee> employee1 = new List<Employee>();
            //Adds value to the employee list
            employee.Add(new Employee()
            {
                employeeId = 45,
                employeeFname = "Grace",
                employeeLname = "Moore"
            });
            //Adds value to the employee list
            employee.Add(new Employee()
            {
                employeeId = 25,
                employeeFname = "Joe",
                employeeLname = "Smith"
            }) ;
            //Adds value to the employee list
            employee.Add(new Employee()
            {
                employeeId = 35,
                employeeFname = "John",
                employeeLname = "Appleseed"
            });
            //Adds value to the employee list
            employee.Add(new Employee()
            {
                employeeId = 40,
                employeeFname = "Jill",
                employeeLname = "Garcia"
            });
            //Adds value to the employee list
            employee.Add(new Employee()
            {
                employeeId = 42,
                employeeFname = "Leah",
                employeeLname = "Jackson"
            });
            //Adds value to the employee list
            employee.Add(new Employee()
            {
                employeeId = 41,
                employeeFname = "Brittany",
                employeeLname = "Cardelli"
            });
            //Adds value to the employee list
            employee.Add(new Employee()
            {
                employeeId = 43,
                employeeFname = "Kinsey",
                employeeLname = "Yin"
            });
            //Adds value to the employee list
            employee.Add(new Employee()
            {
                employeeId = 85,
                employeeFname = "Joe",
                employeeLname = "Scuito"
            });
            //Adds value to the employee list
            employee.Add(new Employee()
            {
                employeeId = 75,
                employeeFname = "Lindsey",
                employeeLname = "Grayson"
            });
            //Adds value to the employee list
            employee.Add(new Employee()
            {
                employeeId = 65,
                employeeFname = "Roman",
                employeeLname = "Velasco"
            });

            //creates a foreach loop iterating through list employee
            foreach (Employee y in employee)
            {
                //if employee contains y
                if (employee.Contains(y))
                {
                    //add to new list 
                    employee1.Add(y);
                    //prints to screen what's in parentheses
                    Console.WriteLine("This name has been repeated");
                    
                }

            }
            //creates new list using lambda function to check for names in the list including Joe.
            List<Employee> joe = employee.Where(x => x.employeeFname == "Joe").ToList();
            //creates a foreach loop 
            foreach (Employee emp in joe)
            {
                //prints to screen first and last name
                Console.WriteLine(emp.employeeFname + emp.employeeLname);
          
            }

            //creates new list newEmployee uses lambda to iterate through and check which employeeIds are greater than 5
            List<Employee> newEmployee = employee.Where(x => x.employeeId > 5).ToList();
            //creates foreach loop iterating through the list of employees with the above requirement
            foreach(Employee emp in newEmployee)
            {
                //prints those ids to screen
                Console.WriteLine(emp.employeeId);
               
            }
            Console.ReadLine();








        }
    }
}
