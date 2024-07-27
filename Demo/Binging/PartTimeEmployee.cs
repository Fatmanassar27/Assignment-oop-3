using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binging
{
    public class PartTimeEmployee : Employee
    {
        public int CountofHours { get; set; }
        public decimal HourRate { get; set; }

        public new void GetEmployeeType()
        {
            Console.WriteLine("I am PartTimeEmployee");
        }
        override public void GetEmployeeData()
        {
            Console.WriteLine($"ID : {Id} , Name : {Name} , Age : {Age} , Count of Hours : {CountofHours}  , Hour Rate : {HourRate}");
        }
    }
}
