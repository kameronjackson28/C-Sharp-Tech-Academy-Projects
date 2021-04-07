using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employee = new List<Employee>();
            List<Employee> employee1 = new List<Employee>();
            employee.Add(new Employee()
            {
                iD = 45,
                employeeName = "Grace Moore"
            });
            employee.Add(new Employee()
            {
                iD = 25,
                employeeName = "Joe Smith"
            });
            employee.Add(new Employee()
            {
                iD = 35,
                employeeName = "John Appleseed"
            });
            employee.Add(new Employee()
            {
                iD = 40,
                employeeName = "Jill Garcia"
            });
            employee.Add(new Employee()
            {
                iD = 42,
                employeeName = "Leah Jackson"
            });
            employee.Add(new Employee()
            {
                iD = 41,
                employeeName = "Brittany Cardelli"
            });
            employee.Add(new Employee()
            {
                iD = 43,
                employeeName = "Kinsey Yin"
            });
            employee.Add(new Employee()
            {
                iD = 45,
                employeeName = "Joe Scuito"
            });
            employee.Add(new Employee()
            {
                iD = 45,
                employeeName = "Lindsey Grayson"
            });
            employee.Add(new Employee()
            {
                iD = 45,
                employeeName = "Roman Velasco"
            });


            //foreach(Employee y in employee)
            //{
            //    if(employee.Contains(y))
            //    {
            //        employee1.Add(y);
            //        Console.WriteLine("This name is repeated");
            //        Console.ReadLine();
            //    }
            //}

            Employee names = employee.Find(name => name.Equals("Joe"));
            Console.WriteLine(names);
            Console.ReadLine();
        }
    }
}
