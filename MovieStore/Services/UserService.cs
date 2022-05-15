using Domain.Classes;
using Domain.Enums;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService
    {
        public void UserInfo(User user) 
        {
            string expiredMsg = "Your membership has expired";
            bool isAnnually = false;
            bool isMonthlyNewMember = false;
            int expirationOfMembershipMonths = 0;
            int expirationOfMembershipDays = 0;
            int expirationOfMembershipYear = 0;
            int todayDate = DateTime.Now.Day;
            int currrentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;
            int dayJoined = Convert.ToInt32(user.DateOfRegistration.Substring(0, 2));
            int monthJoined = Convert.ToInt32(user.DateOfRegistration.Substring(3, 2));
            int yearJoined = 2000 + Convert.ToInt32(user.DateOfRegistration.Substring(6, 2));

            if (user.SubscriptionType == Domain.Enums.SubscriptionType.Monthly)
            {
                if(dayJoined > todayDate) { expirationOfMembershipDays = dayJoined - todayDate; }
                else if (dayJoined < todayDate) { expirationOfMembershipDays = 30 - (todayDate - dayJoined); }
            }
            else if(user.SubscriptionType == Domain.Enums.SubscriptionType.Annually)
            {
                if (monthJoined > currrentMonth && dayJoined > todayDate)
                {
                    expirationOfMembershipMonths = monthJoined - currrentMonth;
                    expirationOfMembershipDays = dayJoined - todayDate;
                }
                else if (monthJoined > currrentMonth && dayJoined < todayDate)
                {
                    expirationOfMembershipMonths = ((monthJoined - currrentMonth) - 1);
                    expirationOfMembershipDays = 30 - (todayDate - dayJoined);
                }
                else if (monthJoined > currrentMonth && dayJoined == todayDate)
                {
                    expirationOfMembershipMonths = monthJoined - currrentMonth;
                }
                else if(monthJoined < currrentMonth && dayJoined < todayDate)
                {
                    expirationOfMembershipMonths = 12 - (currrentMonth - monthJoined) - 1;
                    expirationOfMembershipDays = 30 - (todayDate - dayJoined);
                }
                else if(monthJoined < currrentMonth && dayJoined > todayDate)
                {
                    expirationOfMembershipMonths = 12 - (currrentMonth - monthJoined);
                    expirationOfMembershipDays = dayJoined - todayDate;
                }
                else if (monthJoined < currrentMonth && dayJoined == todayDate)
                {
                    expirationOfMembershipMonths = 12 - (currrentMonth - monthJoined);
                }
                else if (monthJoined == currrentMonth && dayJoined == todayDate && yearJoined != currentYear)
                {
                    expirationOfMembershipDays = 0;
                    expirationOfMembershipMonths = 0;
                    expirationOfMembershipYear = 0;
                    isAnnually = true;
                }
                else if(monthJoined==currrentMonth && dayJoined == todayDate && yearJoined == currentYear)
                {
                    expirationOfMembershipDays = 0;
                    expirationOfMembershipMonths = 0;
                    expirationOfMembershipYear = 1;
                    isMonthlyNewMember = true;
                }
            }

            user.DisplayInfo(user.FirstName, user.LastName, user.DateOfRegistration);

            if (expirationOfMembershipMonths == 0 && expirationOfMembershipDays == 0 && expirationOfMembershipYear == 0 && (isAnnually) && (!isMonthlyNewMember))
            {
                Console.WriteLine(expiredMsg);
            }
            else if (user.SubscriptionType == Domain.Enums.SubscriptionType.Monthly && monthJoined == currrentMonth && dayJoined == todayDate && yearJoined == currentYear)
            {
                Console.WriteLine(($"Subscription type: {user.SubscriptionType} | Expiration of membership: 30 days"));
            }
            else
            {
                if (user.SubscriptionType == Domain.Enums.SubscriptionType.Monthly && (!isMonthlyNewMember))
                {
                    Console.WriteLine($"Subscription type: {user.SubscriptionType} | Expiration of membership: {expirationOfMembershipDays} days");
                }
                else if (user.SubscriptionType == Domain.Enums.SubscriptionType.Annually && expirationOfMembershipYear != 1)
                {
                    Console.WriteLine($"Subscription type: {user.SubscriptionType} |" +
                        $" Expiration of membership: {expirationOfMembershipMonths} months and {expirationOfMembershipDays} days");
                }
                else if (user.SubscriptionType == Domain.Enums.SubscriptionType.Annually && expirationOfMembershipYear == 1)
                {
                    Console.WriteLine($"Subscription type: {user.SubscriptionType} |" +
                        $" Expiration of membership: {expirationOfMembershipYear} year {expirationOfMembershipMonths} months and {expirationOfMembershipDays} days");
                }
                else if (user.SubscriptionType == Domain.Enums.SubscriptionType.Monthly && (isMonthlyNewMember))
                {
                    Console.WriteLine(($"Subscription type: {user.SubscriptionType} | Expiration of membership: {expirationOfMembershipDays} days"));
                }
            }
        }
        public User RegisterUser()
        {
            SubscriptionType typeOfSub = SubscriptionType.Monthly;
            string dateOfReg = string.Empty;
                if (DateTime.Now.Day <= 9 && DateTime.Now.Month <= 9)
                {
                    dateOfReg = $"0{DateTime.Now.Day}/0{DateTime.Now.Month}/{DateTime.Now.Year.ToString().Substring(2, 2)}";
                }
                else if(DateTime.Now.Day <= 9 && DateTime.Now.Month > 9)
                {
                    dateOfReg = $"0{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year.ToString().Substring(2, 2)}";
                } 
                else if (DateTime.Now.Day > 9 && DateTime.Now.Month <= 9)
                {
                    dateOfReg = $"{DateTime.Now.Day}/0{DateTime.Now.Month}/{DateTime.Now.Year.ToString().Substring(2, 2)}";
                }
                else if (DateTime.Now.Day > 9 && DateTime.Now.Month > 9)
                {
                    dateOfReg = $"{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year.ToString().Substring(2, 2)}";
                }

            Console.WriteLine("Enter your first name:");
            string userFirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string userLastName = Console.ReadLine();
            Console.WriteLine("Your username will be automaticly generated. \n Please choose your password");
            string pw = Console.ReadLine();
            Console.WriteLine("What kind of subscription would you like? Type M for monthly or A for annually:");
            string subType = Console.ReadLine();
            if(subType.ToLower()!="m" && subType.ToLower() != "a")
            {
                Console.WriteLine("That's not valid option. Your account was assigned monthly subscription as default subscription.");
            }
            else if (subType.ToLower() == "m")
            {
                typeOfSub = SubscriptionType.Monthly;
                Console.WriteLine("Your account has been successfuly created with monthly subscription.");
            }
            else if (subType.ToLower() == "a")
            {
                typeOfSub = SubscriptionType.Annually;
                Console.WriteLine("Your account has been successfuly created with an annuall subscription.");
            }

            return new User($"{userFirstName.Substring(0,1).ToUpper()}{userFirstName.Substring(1, userFirstName.Length-1)}", $"{userLastName.Substring(0, 1).ToUpper()}{userLastName.Substring(1, userLastName.Length-1)}",
            pw, Role.User, typeOfSub, dateOfReg);
        }
        public string GenerateUserData(User user)
        {
            return $"User: {user.FirstName} {user.LastName} \nUsername: {user.UserName} \nPassword: {user.Password}";
        }
        public bool UserLogin(List<User> users, string usernameInput, string passwordInput)
        {
            foreach (User user in users)
            {
                if (usernameInput == user.UserName && passwordInput == user.Password)
                {
                    return true;
                }
        }
         return false;
        }
        public User GetUser(List<User> users, string usernameInput, string passwordInput)
        {
            foreach (User user in users)
            {
                if (usernameInput == user.UserName && passwordInput == user.Password)
                {
                    return user;
                }
            }
            return null;
        }
        public void RentMovies(User user)
        {
            Console.WriteLine("Select a movie from the list by typing its number (Red color and ** sign indicates movie is rented and not available):");
            foreach(var movie in IntDb.Movies)
            {
                movie.DisplayMovieInfo();
            }
            string rentChoice = Console.ReadLine();
            bool checkRentChoice = int.TryParse(rentChoice, out int parsedChoice);
            if (!checkRentChoice)
            {
                Console.WriteLine("Please enter valid input");
                RentMovies(user);
            } 
            foreach(var movie in IntDb.Movies)
            {
                if (parsedChoice > IntDb.Movies.Count)
                {
                    Console.WriteLine("Please enter valid number for the movie you wish to rent");
                    RentMovies(user);
                    break;
                }
                else if (parsedChoice == movie.InStoreId && !movie.IsRented) 
                {
                    Console.WriteLine($"You have rented the movie {movie.Title}. Have fun watching");
                    movie.IsRented = true;
                    user.Movies.Add(movie);
                }
                else if (parsedChoice == movie.InStoreId && movie.IsRented)
                {
                    Console.WriteLine("You can't rent this movie because it's rented by someone else.");
                    RentMovies(user);
                    break;
                }
            }
        }
        public void CheckRentedMovies(User user)
        {
            if (user.Movies.Count == 0) { Console.WriteLine("You have no rented movies in this moment"); }

            foreach (var movie in user.Movies)
            {
                Console.WriteLine(movie.Title);
            }
        }
        public void UserExit(UserService userService, User user)
        {
            Console.WriteLine("Would you like to return to main menu or exit?");
            Console.WriteLine("1. Return to menu");
            Console.WriteLine("2. Log Out");
            Console.WriteLine("3. Exit");
            string opt = Console.ReadLine();
            switch (opt)
            {
                case "1":
                    userService.UserMenu(userService, user);
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
                    UserExit(userService, user);
                    break;
            }
        }
        public void UserMenu(UserService userService, User user)
        {
            Console.WriteLine("Select an option");
            Console.WriteLine("1. Check info");
            Console.WriteLine("2. See movies");
            Console.WriteLine("3. Rent movie");
            Console.WriteLine("4. See your rented movies");
            Console.WriteLine("5. Log Out");
            string choiceInput = Console.ReadLine();
            switch (choiceInput)
            {
                case "1":
                    userService.UserInfo(user);
                    userService.UserExit(userService, user);
                    break;
                case "2":
                    IntDb.ShowMovies();
                    userService.UserExit(userService, user);
                    break;
                case "3":
                    userService.RentMovies(user);
                    userService.UserExit(userService, user);
                    break;
                case "4":
                    userService.CheckRentedMovies(user);
                    userService.UserExit(userService, user);
                    break;
                case "5":
                    MenuService menuService = new MenuService();
                    menuService.WelcomeMenu();
                    break;
                default:
                    Console.WriteLine("That's not a valid option. Select one of the given choices by typing it's number.");
                    UserMenu(userService, user);
                    break;
            }
        }
        public void UserVerification(UserService userService, List<User> users, string username, string pw)
        {
            if (userService.UserLogin(users, username, pw))
            {
                UserMenu(userService, GetUser(users, username, pw));
            }
            else
            {
                Console.WriteLine("Your details were not recognized. Enter your username or password correctly.");
                Console.WriteLine("Would you like to try again or go back? 1.Try again || 2. Go back");
                string opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        userService.UserVerification(userService, users, IntDb.GetUsername(), IntDb.GetPassword());
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