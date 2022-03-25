using System;
using System.Collections.Generic;
using System.Text;

namespace classesHomework.Models
{
    public class Car
    {
        public string Model { get; set; }
        public Driver Driver { get; set; }
        public int Speed { get; set; }
        public int Id { get; set; }

        public Car(string model, Driver driver, int speed, int id)
        {
            Model = model;
            Driver = driver;
            Speed = speed;
            Id = id;
            CalculateSpeed(this, Driver);
        }
        public int CalculateSpeed(Car car, Driver driver)
        {
            int speed = car.Speed * driver.Skill;
            return speed;
        }
    }
}