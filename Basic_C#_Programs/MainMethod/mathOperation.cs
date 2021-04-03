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

        public static string myMath(string i)
        {
            int z = Convert.ToInt32(i);

            return z / 6;
        }
    }
}
