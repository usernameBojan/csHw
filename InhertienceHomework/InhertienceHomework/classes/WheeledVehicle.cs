using System;
using System.Collections.Generic;
using System.Text;

namespace InhertienceHomework.classes
{
    public class WheeledVehicle : Vehicle
    {
        public int numOfWheels { get; set; }
        public string Type { get; set; }

        public virtual void Repair()
        {
          Console.WriteLine("Vehicle has been repaired.");
        }
    }
}
