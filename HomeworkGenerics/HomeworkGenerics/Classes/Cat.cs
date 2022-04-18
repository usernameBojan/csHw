using HomeworkGenerics.Enums;
using HomeworkGenerics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkGenerics.Classes
{
    public class Cat : Pet, ICat
    {
        public int LivesLeft { get; set; }
        public bool IsLazy { get; set; }
        public override string PrintInfo()
        {
            return $"{Name} | {Age} | {Type}";
        }
        public Cat() { }
        public Cat(string name, int age, Enums.Type type, int livesLeft, bool isLazy) : base(name, age, type)
        {
            IsLazy = isLazy;
            LivesLeft = livesLeft;
        }
    }
}