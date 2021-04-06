using System;
using System.Collections.Generic;

namespace GenParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "Roman", "Grace", "Jill" };

            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int>() { 412, 321, 451 };

         

            foreach (string i in employee.Things)
            {
                Console.WriteLine(i);

            }
            foreach (int i in employee1.Things)
            {
                Console.WriteLine(i);

            }
        }
    }
}
 