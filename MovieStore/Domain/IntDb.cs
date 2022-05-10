using Domain.Classes;
using Domain.Enums;


namespace Domain
{
    public static class IntDb
    {
        public static void ShowMovies()
        {
            foreach (var movie in IntDb.Movies)
            {
                movie.DisplayMovieInfo();
            }
        }
        public static string GetUsername()
        {
            Console.WriteLine("Enter your username and password");
            Console.WriteLine("Username:");
            string usernameInput = Console.ReadLine();
            return usernameInput;
        }
        public static string GetPassword()
        {
            Console.WriteLine("Password");
            string passwordInput = Console.ReadLine();
            return passwordInput;
        }

        public static List<Employee> Employees = new List<Employee>() 
        {
            new Employee("Dante", "Hicks", Enums.Role.Employee, "0000"),
            new Employee("Randal", "Graves", Enums.Role.Employee, "1111")
        };
        
        public static List<User> Users = new List<User>()
        {
            new User("John", "Smith", "000000", Enums.Role.User, Enums.SubscriptionType.Annually, "13/01/22"),
            new User("John", "Doe", "000000", Enums.Role.User, Enums.SubscriptionType.Monthly, "28/02/22"),
            new User("Jane", "Smith", "000000", Enums.Role.User, Enums.SubscriptionType.Monthly, "14/03/22"),
            new User("Jan", "Kowalski", "000000", Enums.Role.User, Enums.SubscriptionType.Annually, "15/03/22"),
            new User("Ivan", "Kovalenko", "000000", Enums.Role.User, Enums.SubscriptionType.Annually, "29/03/22"),
            new User("Jovan", "Kovachev", "000000", Enums.Role.User, Enums.SubscriptionType.Monthly, "08/03/22")
        };

        public static List<Movie> Movies = new List<Movie>()
        {
            new Movie()
            {
                Title = "The Shining",
                Year = 1980,
                Description = "A family heads to an isolated hotel for the winter where a sinister presence influences the father into violence," +
                " while his psychic son sees horrific forebodings from both past and future.",
                Genre = Enums.Genre.Horror,
                IsRented = true,
                InStoreId = 1
            },
            new Movie()
            {
                Title = "Doctor Sleep",
                Year = 2019,
                Description = "Years following the events of The Shining (1980), a now-adult Dan Torrance " +
                "must protect a young girl with similar powers from a cult known as The True Knot, who prey on children with powers to remain immortal.",
                Genre = Enums.Genre.Horror,
                IsRented = false, 
                InStoreId = 2
            },
            new Movie()
            {
                Title = "Star Wars",
                Year = 1977,
                Description = "Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a Wookiee and two droids " +
                "to save the galaxy from the Empire's world-destroying battle station, while also attempting to rescue Princess Leia from the mysterious Darth Vader.",
                Genre = Enums.Genre.SciFi,
                IsRented = false,
                InStoreId = 3
            },
            new Movie()
            {
                Title = "Napoleon Dynamite",
                Year = 2004,
                Description = "A listless and alienated teenager decides to help his new friend win the class presidency " +
                "in their small western high school, while he must deal with his bizarre family life back home.",
                Genre = Enums.Genre.Indie,
                IsRented = true,
                InStoreId = 4
            },
            new Movie()
            {
                Title = "White House Down",
                Year = 2013,
                Description = "While on a tour of the White House with his young daughter," +
                " a Capitol policeman springs into action to save his child and protect the president from a heavily armed group of paramilitary invaders.",
                Genre = Enums.Genre.Action,
                IsRented = false,
                InStoreId = 5
            },
            new Movie()
            {
                Title = "Get Out",
                Year = 2017,
                Description = "A young African-American visits his white girlfriend's parents for the weekend, " +
                "where his simmering uneasiness about their reception of him eventually reaches a boiling point.",
                Genre = Enums.Genre.Horror,
                IsRented = true,
                InStoreId = 6
            },
            new Movie()
            {
                Title = "The Shawshank Redemption",
                Year = 1994,
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                Genre = Enums.Genre.Drama,
                IsRented = false,
                InStoreId = 7
            },
            new Movie()
            {
                Title = "Love & Other Drugs",
                Year = 2010,
                Description = "In 1990s Pittsburgh, a medicine peddler starts a relationship with a young woman suffering from Parkinson's disease.",
                Genre = Enums.Genre.Romance,
                IsRented = false,
                InStoreId = 8
            },
            new Movie()
            {
                Title = "This Is The End",
                Year = 2013,
                Description = "Six Los Angeles celebrities are stuck in James Franco's house after a series of devastating events just destroyed the city. " +
                "Inside, the group not only have to face the apocalypse, but themselves.",
                Genre = Enums.Genre.Comedy,
                IsRented = false,
                InStoreId = 9
            },
            new Movie()
            {
                Title = "Mystic River",
                Year = 2003,
                Description = "The lives of three men who were childhood friends are shattered when one of them has a family tragedy.",
                Genre = Enums.Genre.Romance,
                IsRented = false,
                InStoreId = 10
            },
            new Movie()
            {
                Title = "Pulp Fiction",
                Year = 1994,
                Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption..",
                Genre = Enums.Genre.Crime,
                IsRented = true,
                InStoreId = 11
            },
            new Movie()
            {
                Title = "The Brothers Grimm",
                Year = 2005,
                Description = "Will and Jake Grimm are traveling con-artists who encounter a genuine fairy-tale curse which requires true courage instead of their usual bogus exorcisms",
                Genre = Enums.Genre.Fantasy,
                IsRented = false,
                InStoreId = 12
            },
            new Movie()
            {
                Title = "Arrival",
                Year = 2015,
                Description = "A linguist works with the military to communicate with alien lifeforms after twelve mysterious spacecraft appear around the world.",
                Genre = Enums.Genre.SciFi,
                IsRented = false,
                InStoreId = 13
            },
            new Movie()
            {
                Title = "Inglourious Basterds",
                Year = 2009,
                Description = "In Nazi-occupied France during World War II, " +
                "a plan to assassinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same.",
                Genre = Enums.Genre.Action,
                IsRented = false,
                InStoreId = 14
            }
        };
    }
}