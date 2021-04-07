using System;
using System.Collections.Generic;
using System.Text;

namespace ParsingEnums
{
    class Enum
    {
        public static DaysOfWeek Parse<DaysOfWeek>(string user) where DaysOfWeek : struct;
       
        
           
        
        
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
