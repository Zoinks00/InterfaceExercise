using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV: IVehicle, ICompany
    {
        public bool RoofRack { get; set; } = true;
        public string CargoSpace { get; set; } 
        public int Wheels { get; set; }
        public int Seats { get; set; }
        public string Media { get; set; }
        public string Fuel { get; set; }
        public string Logo { get; set; }
        public string Motto { get; set; }

        public void DisplayLogo()
        {
            Console.WriteLine($"Logo = {Logo}");
        }

        public void DisplayMotto()
        {
            Console.WriteLine($"Motto = {Motto}");
        }

        public void DisplayFeature()
        {
            Console.WriteLine($"RoofRack = {RoofRack}\nCargoSpace = {CargoSpace}");
        }


    }
}
