using System;

namespace GenParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            things<string> employee = new things<string>();
            employee.Things("Roman", "Grace", "Jill");
        }
    }
}
