using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
   public interface IVehicle
    {
        

        public int Wheels { get; set; }
        public int Seats { get; set; }
        public string Media { get; set; }
        public string Fuel { get; set; }
        
        
        void DisplayLogo();

        void DisplayMotto();

        void DisplayFeature();

        
          
    }
}
