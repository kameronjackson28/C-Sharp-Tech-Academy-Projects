using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethod
{
    class mathOperation
    {
        //creates int myMath method passing int x as the parameter
        public static int myMath(int x)
        {
            //returns x + 4
            return (x + 4);
        }

        //creates decimal myMath method passing decimal y as the parameter
        public static decimal myMath(decimal y)
        {
            //creates new int variable newNum which converts decimal y into an integer
            int newNum = Convert.ToInt32(y);
            //returns int newNum * 7
            return (newNum * 7);
        }

        //creates int myMath method passing string z as the parameter
        public static int myMath(string z)
        {
           //converts string z into an integer variable named a 
           int a = Convert.ToInt32(z);

            //returns 10 / a 
            return (10 / a);
        }
    }
}
