using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethod
{
    class mathOperation
    {
        public static int myMath(int x)
        {
            return (x + 4);
        }

        public static decimal myMath(decimal y)
        {
            return (y * 7);
        }

        public static string myMath(string z)
        {
            int a = Convert.ToInt32(z);

            return (a / 6);
        }
    }
}
