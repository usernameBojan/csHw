using AbstractClassesAndInterfacesHw.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfacesHw.Models
{
    public class Cat : Animal, ICat
    {
        public int LivesRemaining { get; set; }
        public bool IsLazy { get; set; }
        public Cat(string name, string color, Kind kind, int age, int livesRemaining, bool isLazy) : base(name, color, kind, age)
        {
            LivesRemaining = livesRemaining;
            IsLazy = isLazy;
        }
        public void Eats(string food)
        {
            Console.WriteLine($"{Name} is eating {food}");
        }
        public override string PrintInfo()
        {
            if (IsLazy) { return $"{Name} is one lazy {Color} {Kind.feline}. It has {Age} years and {LivesRemaining} lives remaining"; }
            else { return $"{Name} is one not so lazy {Color} {Kind.feline}. It has {Age} years and {LivesRemaining} lives remaining"; }
        }
    }
}
