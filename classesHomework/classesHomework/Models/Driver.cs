using System;
using System.Collections.Generic;
using System.Text;

namespace classesHomework.Models
{
    public class Driver
    {
        public string Name { get; set; }
        public int Skill { get; set; }
        public int Id { get; set; }
        public Driver(string name, int skill, int id)
        {
            Name = name;
            Skill = skill;
            Id = id;
        }
    }
}