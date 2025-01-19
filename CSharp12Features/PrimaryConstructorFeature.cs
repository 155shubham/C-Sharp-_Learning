using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp12Features
{
    //Demo for Primary contructor in class (older way)
    public class EmployeeOldWayConstructor()
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public EmployeeOldWayConstructor(string firstName, string lastName) : this()
        {
            {
                FirstName = firstName;
                LastName = lastName;
            }
        }  
    }

    //Demo for Primary contructor in class (newer way)
    public class EmployeeNewWayConstructor(string firstName, string lastName)
    {
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;

    }


    //Demo for Primary contructor in struct
    public struct FindArea(int l, int b)
    {
        public int Area = l * b;
    }

    //Demo for Primary contructor in record
    public record EmployeeRecord(string firstName, string lastName);
}
