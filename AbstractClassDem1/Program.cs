using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              * Todo: Follow all comments!! 
              * Double click on the region (gray box) to view all comments
              */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
        Done  * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */
            //Done
            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
        Done    */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicle = new List<Vehicle>();
            Car car1 = new Car()
            {
                HasTrunk = true,
                Make = "Honda",
                Model = "Civic",
                Year = 2022
            };

            Vehicle myCar = new Car()
            {
                HasTrunk = true,
                Make = "Mitsobishi",
                Model = "Mits",
                Year = 2020
            };

            Vehicle car2 = new Car()
            {
                HasTrunk = false,
                Model = "Tesla",
                Make = "T22",
                Year = 2022
            };


            Motorcycle Motor = new Motorcycle();
            Motor.HasSideCart = "yes";
            Motor.Make = "no";
            Motor.Model = "PS3";

            vehicle.Add(car1);
            vehicle.Add(myCar);
            vehicle.Add(car2);
            vehicle.Add(Motor);
            foreach(var Car in  vehicle)
            {
                Console.WriteLine($"Year {Car.Year} Make {Car.Make} Model {Car.Model}");
            }


            Console.WriteLine("Calling each car");

            car1.DriveAbstract();
            myCar.DriveAbstract();
            car2.DriveAbstract();
            Motor.DriveAbstract();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle
             * (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion
            Console.ReadLine();
        }
    }
}
