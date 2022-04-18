using HomeworkGenerics.Enums;
using HomeworkGenerics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkGenerics.Classes
{
    public class Fish : Pet, IFish
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public Fish() { }
        public Fish(string name, int age, Enums.Type type, string color, string size) : base(name, age, type) 
        {
            Color = color;
            Size = size;
        }
        public override string PrintInfo()
        {
            return $"{Name} | {Age} | {Type} | {Color} | {Size}";
        }

        public static implicit operator Fish(List<Fish> v)
        {
            throw new NotImplementedException();
        }
    }
}