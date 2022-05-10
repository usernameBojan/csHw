using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Employee : Member
    {
        private int Salary { get; set; }
        public int HoursPerMonth { get; set; }
        public int? Bonus { get; set; }

        public Employee() { }
        public Employee(string firstName, string lastName, Role role, string password) : base(firstName, lastName, role)
        {
            Password = password;
        }
        public static int SetBonus(int hpm, int salary, double? bonus)
        {
            bonus = null;
            if (hpm > 160) { bonus = 0.3; }
            return Convert.ToInt32(bonus);
        }
        public static int SetSalary(int hpm, int salary, double? bonus)
        {
            if (bonus == null) { salary = 300; }
            else { salary = 300 + (hpm * Convert.ToInt32(bonus)); }
            return salary;
        }
    }
}
