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
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle - DONE
             * The vehicle class shall have three string properties Year, Make, and Model - DONE
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation - DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. - DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle - DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle-DONE
             * Provide the implementations for the abstract methods-DONE
             * Only in the Motorcycle class will you override the virtual drive method-DONE
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class - DONE
             * Set the properties with object initializer syntax - DONE
             */
            Car focus = new Car() { HasTrunk = true, Make = "Ford", Model = "Focus", Year = 2013 };
            Motorcycle motorcycle = new Motorcycle() { HasSideCart = true, Make = "Harley Davidson", Model = "Chopper", Year = 1978 };
            Vehicle sedan = new Car() { HasTrunk = true, Make = "Dodge", Model = "Van", Year = 1999 };
            Vehicle sport = new Car() { HasTrunk = false, Make = "Ferrari", Model = "Money Pit", Year = 2020 };
            /*
             * Add the 4 vehicles to the list - DONE
             * Using a foreach loop iterate over each of the properties - DONE
             */
            vehicles.Add(focus);
            vehicles.Add(motorcycle);
            vehicles.Add(sedan);
            vehicles.Add(sport);
            foreach(var item in vehicles)
            {
                Console.WriteLine($"Make {item.Make}, Model {item.Model}, Year {item.Year}");
                item.DriveAbstract();
                item.DriveVirtual();
                Console.WriteLine("--------------");
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
