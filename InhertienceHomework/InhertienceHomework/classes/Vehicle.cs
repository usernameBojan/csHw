using System;
using System.Collections.Generic;
using System.Text;

namespace InhertienceHomework.classes
{
    public class Vehicle
    {
        private int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public Vehicle()
        {
            Id = new Random().Next(1, 9999999);
        }

        public Vehicle(string model, string manufacturer)
        {
            Id = new Random().Next(1, 9999999);
            Model = model;
            Manufacturer = manufacturer;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Model of vehicle is {Model}, manufactured by {Manufacturer} with ID number {Id}.");
        }
    }
}
