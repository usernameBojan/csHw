using AbstractClassesAndInterfacesHw.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfacesHw.Models
{
    public class Dog : Animal, IDog
    {
        public int DogYears { get; set; }
        public bool IsFaithful { get; set; }
        public Dog(string name, string color, Kind kind, int age, bool isFaithful) : base(name, color, kind, age)
        {
            DogYears = age * 7;
            IsFaithful = isFaithful;
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} says AW AW!");
        }
    public override string PrintInfo()
    {
        if (IsFaithful) { return $"{Name} is one faithful {Color} {Kind.canine}. It has {Age} years or {DogYears} dog years"; }
        else { return $"{Name} is one not so faithful {Color} {Kind.canine}. It has {Age} years or {DogYears} dog years"; }
    }
}
}
