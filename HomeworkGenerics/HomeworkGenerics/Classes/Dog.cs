using HomeworkGenerics.Enums;
using HomeworkGenerics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkGenerics.Classes
{
    public class Dog : Pet, IDog
    {
        public bool IsGoodBoy { get; set; }
        public string FavoriteFood { get; set; }
        public override string PrintInfo()
        {
            return $"{Name}| {Age} | {Type}";
        }
        public Dog() { }
        public Dog(string name, int age, Enums.Type type, bool isGoodBoy, string faveFood) : base (name, age, type)
        {
            IsGoodBoy = isGoodBoy;
            FavoriteFood = faveFood;
        }
    }
}