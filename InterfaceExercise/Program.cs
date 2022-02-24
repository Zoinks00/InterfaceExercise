using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Complete -Create 2 Interfaces called IVehicle & ICompany

            //Complete -Create 3 classes called Car , Truck , & SUV

            //Complete - In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //Complete - In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //Complete - In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
          
            var car = new Car();
            {
                car.Logo = "Mazda";
                car.Motto = "Zoom Zoom";
                car.Convertible = true;
                car.Trunk = "Small";
                car.Wheels = 4;
                car.Seats = 2;
                car.Media = "Radio/CD/Satellite";
                car.Fuel = "Ethanol";

            }

            var truck = new Truck();
            {
                truck.Logo = "Ford";
                truck.Motto = "Found On Roadside Dead";
                truck.CabSize = "Dual";
                truck.TruckBed = "Regular";
                truck.Wheels = 6;
                truck.Seats = 5;
                truck.Media = "Radio";
                truck.Fuel = "Diesel";
            }

            var suv = new SUV();
            {
                suv.Logo = "Jeep";
                suv.Motto = "Just Empty Every Pocket";
                suv.RoofRack = true;
                suv.CargoSpace = "Mid";
                suv.Wheels = 4;
                suv.Seats = 5;
                suv.Media = "Radio/CD/Satellite";
                suv.Fuel = "Ethanol";
            }

            List<IVehicle> vehicles = new List<IVehicle>();
            vehicles.Add(car);
            vehicles.Add(truck);
            vehicles.Add(suv);
            
            

            foreach ( IVehicle veh in vehicles)
            {
                veh.DisplayLogo();
                veh.DisplayMotto();
                veh.DisplayFeature();
                Console.WriteLine($"Wheels = {veh.Wheels}\nSeats = {veh.Seats}\nMedia = {veh.Media}\nFuel = {veh.Fuel}\n");
                Console.WriteLine("-----------\n");
               

                

            }

          

        } 
        
        public static void CompanyInfo()
            {


            }
    }
}
