using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        internal int PhoneNumber { get; set; }
        public string DateOfRegistration { get; set; }
        public Role Role { get; set; }
        public Member() { }
        public Member(string firstName, string lastName, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
        }
        public virtual void DisplayInfo(string name, string surname, string dateOfReg)
        {
            Console.WriteLine($"{name} {surname} | Registered on: {dateOfReg}");
        }
    }
}