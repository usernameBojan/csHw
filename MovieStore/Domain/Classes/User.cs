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
            UserName = $"{firstName.Substring(0, 3).ToLower()}{lastName.Substring(0, 3).ToLower()}";
            Movies = new List<Movie>();
        }

        public override void DisplayInfo(string name, string surname, string dateOfReg)
        {
            Console.WriteLine($"{name} {surname} | Username: {UserName} | Registered on: {dateOfReg}");
        }
    }
}
