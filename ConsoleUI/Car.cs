using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool hasTrunk { get; set; }
        public Car()
        {
            Year = "year";
            Make = "make";
            Model = "model";
            hasTrunk = true;
        }

        public override void DriveAbstract()
        {
            Console.WriteLine($"The {Year} {Make} {Model} is being driven.");
        }
    }
}
