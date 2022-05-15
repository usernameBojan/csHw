using Domain.Classes;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EmployeeService
    {
        public void ShowUsers()
        {
            foreach(var user in IntDb.Users)
            {
                user.DisplayInfo(user.FirstName, user.LastName, user.DateOfRegistration);
            }
        }
        public bool DoesUserExists(List<User> users, string userName)
        {
            foreach (User user in users)
            {
                if (user.UserName == userName)
                {
                    return true;
                }
            }
            return false;
        }
        public void DeleteUser(List<User> users, string userName)
        {
            if(DoesUserExists(users, userName))
            {
                foreach (User user in users)
                {
                    if (user.UserName == userName)
                    {
                        users.Remove(user);
                        Console.WriteLine($"User {user.FirstName} {user.LastName} was successfully removed.");
                        break;
                    }
                }
            }
            else { Console.WriteLine("There is no such user."); }
        }
        public void AddUsers(List<User> users, User user)
        {
            users.Add(user);
        }
        public bool EmployeeLogin(List<Employee> employees)
        {
            Console.WriteLine("Enter your credentials");
            Console.WriteLine("Name:");
            string employeeNameInput = Console.ReadLine();
            Console.WriteLine("Password");
            string passwordInput = Console.ReadLine();

            foreach (Employee employee in employees)
            {
                if (employeeNameInput.ToLower() == employee.FirstName.ToLower() && passwordInput == employee.Password)
                {
                    return true;
                }
            }
            return false;
        }
        public void EmployeeExit(EmployeeService employeeService)
        {
            Console.WriteLine("Would you like to return to main menu or exit?");
            Console.WriteLine("1. Return to menu");
            Console.WriteLine("2. Log Out");
            Console.WriteLine("3. Exit");
            string opt = Console.ReadLine();
            switch (opt)
            {
                case "1":
                    employeeService.EmployeeMenu(employeeService);
                    break;
                case "2":
                    MenuService menuService = new MenuService();
                    menuService.WelcomeMenu();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("That's not a valid option, please choose one of the options by typing it's number.");
                    EmployeeExit(employeeService);
                    break;
            }
        }
        public void EmployeeMenu(EmployeeService employeeService)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. See users.");
            Console.WriteLine("2. See movies.");
            Console.WriteLine("3. Add new user.");
            Console.WriteLine("4. Remove existing user.");
            Console.WriteLine("5. Log Out");
            string choiceInput = Console.ReadLine();
            switch (choiceInput)
            {
                case "1":
                    employeeService.ShowUsers();
                    employeeService.EmployeeExit(employeeService);
                    break;
                case "2":
                    IntDb.ShowMovies();
                    employeeService.EmployeeExit(employeeService);
                    break;
                case "3":
                    UserService userService = new UserService();
                    User newUser = userService.RegisterUser();
                    Console.WriteLine(userService.GenerateUserData(newUser));
                    employeeService.AddUsers(IntDb.Users, newUser);
                    employeeService.EmployeeExit(employeeService);
                    break;
                case "4":
                    Console.WriteLine("Enter the username of the user you wish to remove:");
                    string userToRemove = Console.ReadLine();
                    employeeService.DeleteUser(IntDb.Users, userToRemove);
                    employeeService.EmployeeExit(employeeService);
                    break;
                case "5":
                    MenuService menuService = new MenuService();
                    menuService.WelcomeMenu();
                    break;
                default:
                    Console.WriteLine("That's not a valid option. Select one of the given choices by typing it's number.");
                    EmployeeMenu(employeeService); 
                    break;
            }
        }
        public void EmployeeVerification(EmployeeService employeeService, List<Employee> employees)
        {
            if (employeeService.EmployeeLogin(employees)) 
            {
                EmployeeMenu(employeeService);
            }
            else
            {
                Console.WriteLine("Your credentials were not recognized. Enter your username or password correctly.");
                Console.WriteLine("Would you like to try again or go back? 1.Try again || 2. Go back");
                string opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        employeeService.EmployeeVerification(employeeService, employees);
                        break;
                    case "2":
                        MenuService menuService = new MenuService();
                        menuService.WelcomeMenu();
                        break;
                    default:
                        Console.WriteLine("Error. Try again");
                        MenuService newMenu = new MenuService();
                        newMenu.WelcomeMenu();
                        break;
                }
            }
        }
    }
}