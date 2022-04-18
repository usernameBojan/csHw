using HomeworkGenerics.Enums;
using HomeworkGenerics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkGenerics.Classes
{
    public abstract class Pet : IPet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Enums.Type Type { get; set; }
        public abstract string PrintInfo();
        public Pet() { }
        public Pet(string name, int age, Enums.Type type)
        {
            Name = name;
            Age = age;  
            Type = type;
        }
    }
}
