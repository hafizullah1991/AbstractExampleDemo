using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public string HasSideCart { get; set; } = "yes";

        public override void DriveAbstract()
        {
            Console.WriteLine($"{Make} {Model} very expensive(it's mortorcycle)");
        }

      
    }
}
