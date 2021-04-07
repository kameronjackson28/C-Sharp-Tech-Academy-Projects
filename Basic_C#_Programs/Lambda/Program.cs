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


            List<Employee> employee = new List<Employee>();
            List<Employee> employee1 = new List<Employee>();
            employee.Add(new Employee()
            {
                employeeId = 45,
                employeeName = "Grace Moore"
            });
            employee.Add(new Employee()
            {
                employeeId = 25,
                employeeName = "Joe Smith"
            });
            employee.Add(new Employee()
            {
                employeeId = 35,
                employeeName = "John Appleseed"
            });
            employee.Add(new Employee()
            {
                employeeId = 40,
                employeeName = "Jill Garcia"
            });
            employee.Add(new Employee()
            {
                employeeId = 42,
                employeeName = "Leah Jackson"
            });
            employee.Add(new Employee()
            {
                employeeId = 41,
                employeeName = "Brittany Cardelli"
            });
            employee.Add(new Employee()
            {
                employeeId = 43,
                employeeName = "Kinsey Yin"
            });
            employee.Add(new Employee()
            {
                employeeId = 85,
                employeeName = "Joe Scuito"
            });
            employee.Add(new Employee()
            {
                employeeId = 75,
                employeeName = "Lindsey Grayson"
            });
            employee.Add(new Employee()
            {
                employeeId = 65,
                employeeName = "Roman Velasco"
            });

            //foreach (Employee y in employee)
            //{
            //    if (employee.Contains(y))
            //    {
            //        employee1.Add(y);
            //        Console.WriteLine("This name is repeated");
            //        Console.ReadLine();
            //    }
                
            //}

            //foreach (var y in employee.Where(y => employee.Contains(y)))
            //{
            //    employee1.Add(y);
            //    Console.WriteLine("This name is repeated");
            //    Console.ReadLine();
            //}

            List<Employee> newEmployee = employee.Where(x => x.employeeId > 5).ToList();
            Console.WriteLine(newEmployee);
            Console.ReadLine();








        }
    }
}
