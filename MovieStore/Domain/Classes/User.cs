using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class User : Member
    {
        private int MemberNum { get; set; }
        public string UserName { get; set; }    
        public List<Movie> Movies { get; set; }
        public SubscriptionType SubscriptionType { get; set; }

        public User() { }
        public User(string firstName, string lastName, string password, Role role, SubscriptionType subscription, string dateOfReg) : base(firstName, lastName, role)
        {
            SubscriptionType = subscription;
            DateOfRegistration = dateOfReg;
            Password = password;
            UserName = GenerateUsername(firstName, lastName);
            Movies = new List<Movie>();
        }
        public string GenerateUsername(string name, string surname) 
        {
            string username = string.Empty;

            if (name.Length >= 3 && surname.Length >= 3)
            {
                username = $"{name.Substring(0, 3).ToLower()}{surname.Substring(0, 3).ToLower()}";
            }
            else if (name.Length > 3 && surname.Length < 3) 
            {
                username = $"{name.Substring(0, 3).ToLower()}{surname.ToLower()}";
            }
            else if (name.Length < 3 && surname.Length > 3)
            {
                username = $"{name.ToLower()}{surname.Substring(0, 3).ToLower()}";
            }
            else if (surname.Length < 3 && surname.Length < 3)
            {
                username = $"{name.ToLower()}{surname.ToLower()}";
            }
            return username;

        }
        public override void DisplayInfo(string name, string surname, string dateOfReg)
        {
            Console.WriteLine($"{name} {surname} | Username: {UserName} | Registered on: {dateOfReg}");
        }
    }
}