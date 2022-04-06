using System;
using System.Collections.Generic;
using System.Text;

namespace InhertienceHomework.classes
{
    public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }
        public int BatteryPercentage { get; set; }

        public ElectricCar() { }
        public ElectricCar(int batteryCap, int batteryPercent)
        {
            BatteryCapacity = batteryCap;
            BatteryPercentage = batteryPercent;
        }
        public static void Recharge()
        {
            Console.WriteLine("Car has been recharged");
        }
    }
}
