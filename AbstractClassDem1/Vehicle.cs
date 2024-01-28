using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        // Properties
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Camery";
        public int Year { get; set; } = 2030;

        // Abstract method to start the vehicle (specific implementation in derived classes)
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"{Make} {Model} very expensive (vehicle)");
        }
    }


}

