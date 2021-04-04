using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MethodSubmission
{
    //creates class named Data
    class Data
    {
        //creates int method mathOp passing y as a parameter and z as an optional parameter set to 4
        public static int mathOp(int y, int z = 4)
        {
            //returns y * z * 25
            return (y * z * 25);
        }
    }
}
