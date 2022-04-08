using AbstractClassesAndInterfacesHw.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfacesHw.Models
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public Kind Kind { get; set; }
        public int Age { get; set; }
        public abstract string PrintInfo();

        public void Bark()
        {
            Console.WriteLine($"{Name} says AW AW!");
        }

        public void Eats(string food)
        {
            Console.WriteLine($"{Name} is eating {food}");
        }

        public Animal(string name, string color, Kind kind, int age)
        {
            Name = name;
            Color = color;
            Kind = kind;
            Age = age;
        }

    }
}
