using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Vs_NonStatic
{
    public class Utility
    {


        //explicitly mention the values in static method as it cannot work upon instance variables
        public static int ComputeSomething(int a, int b)
        {
            int someValue = a*b;

            //do calculation base upon EmployeeId
            return someValue;

        }
    }

}
