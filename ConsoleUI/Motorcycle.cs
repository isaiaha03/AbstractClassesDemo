using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool hasSideCart { get; set; }
        public Motorcycle()
        {
            Year = "year";
            Make = "make";
            Model = "model";
            hasSideCart = true;
        }

        public override void DriveAbstract()
        {
            Console.WriteLine($"The {Year} {Make} {Model} is being ridden.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"The {Year} {Make} {Model} motorcycle is being ridden.");
        }
    }
}
