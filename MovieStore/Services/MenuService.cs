using Domain;
using Domain.Classes;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MenuService
    {
        EmployeeService employeeService = new EmployeeService();
        UserService userService = new UserService();
        public void WelcomeMenu()
        {
            Console.WriteLine("Welcome to our moviestore! Please select which operation would you like to perform:");
            Console.WriteLine("1. Employee Log In");
            Console.WriteLine("2. Log In as existing user.");
            Console.WriteLine("3. New user registration.");
            Console.WriteLine("4. Exit.");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    employeeService.EmployeeVerification(employeeService, IntDb.Employees);
                    break;
                case "2":
                    userService.UserVerification(userService, IntDb.Users, IntDb.GetUsername(), IntDb.GetPassword());
                    break;
                case "3":
                    User newUser = userService.RegisterUser();
                    IntDb.Users.Add(newUser);
                    Console.WriteLine(userService.GenerateUserData(newUser));
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("That's not a valid option. Select one of the given choices.");
                    break;
            }
        }
    }
}