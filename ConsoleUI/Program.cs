﻿using System;
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
             *DONE Create an abstract class called Vehicle
             *DONE The vehicle class shall have three string properties: Year, Make, and Model
             *DONE Set the defaults of the properties to something generic in the Vehicle class
             *DONE Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             *DONE Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             *DONE Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             *DONE Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             *DONE Provide the implementations for the abstract methods
             *DONE Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             *DONE Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             *DONE Set the properties values with object initializer syntax
             */
            Car car = new Car
            {
                Year = "2022",
                Make = "Toyota",
                Model = "Camry",
                hasTrunk = true
            };
            vehicles.Add(car);

            Motorcycle motorcycle = new Motorcycle
            {
                Year = "2021",
                Make = "Harley-Davidson",
                Model = "Iron 883",
                hasSideCart = false
            };
            vehicles.Add(motorcycle);

            Vehicle vehicle1 = new Car
            {
                Year = "2019",
                Make = "Ford",
                Model = "Mustang",
                hasTrunk = true
            };
            vehicles.Add(vehicle1);

            Vehicle vehicle2 = new Motorcycle
            {
                Year = "2020",
                Make = "Honda",
                Model = "CBR600RR",
                hasSideCart = false
            };
            vehicles.Add(vehicle2);
            /*
             *DONE Add the 4 vehicles to the list
             *DONE Using a foreach loop iterate through the list and display each of the properties
             */
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}, Make: {vehicle.Make}, Model: {vehicle.Model}");

                if (vehicle is Car)
                {
                    vehicle.DriveAbstract();
                    vehicle.DriveVirtual();
                }
                else if (vehicle is Motorcycle)
                {
                    vehicle.DriveAbstract();
                    vehicle.DriveVirtual();
                }

                Console.WriteLine();
            }

            //DONE Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
