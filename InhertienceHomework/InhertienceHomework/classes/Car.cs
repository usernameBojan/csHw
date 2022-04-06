using System;
using System.Collections.Generic;
using System.Text;

namespace InhertienceHomework.classes
{
    public class Car : WheeledVehicle
    {
        public int FuelConsumption { get; set; }
        public int NumOfDoors { get; set; }
        public int MaxSpeed { get; set; }
        public EngineType EngineType { get; set; }
        public Car() { }
        public Car(int fuelConsum, int numOfDoors, int maxSpeed, EngineType engineType)
        {
            FuelConsumption = fuelConsum;
            NumOfDoors = numOfDoors;
            MaxSpeed = maxSpeed;
            EngineType = engineType;
        }
        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }

        public override void Repair()
        {
          Console.WriteLine("Car has been repaired. 🔧");
        }
    }
}
