using System;
using System.Collections.Generic;
using System.Text;

namespace InhertienceHomework.classes
{
    class Bicyle : WheeledVehicle
    {
        int NumOfSpeedLevels { get; set; }
        bool IsElectric { get; set; }

        public Bicyle() { }
        public Bicyle(int speedLevels, bool isElectric)
        {
            NumOfSpeedLevels = speedLevels;
            IsElectric = isElectric;
        }
        public void Ride()
        {
            Console.WriteLine("This bike is being ridden.");
        }

        public override void Repair()
        {
            Console.WriteLine("Bike has been repaired.");
        }
    }
}
