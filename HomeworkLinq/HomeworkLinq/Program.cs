using System;
using System.Collections.Generic;
using System.Linq;


namespace HomeworkLinq
{
    class Program
    {
		static void Main(string[] args)
		{
			List<Person> people = new List<Person>()
			{
			new Person("Bill", "Smith", 41, 'M'),
			new Person("Sarah", "Jones", 22, 'F'),
			new Person("Stacy","Baker", 21, 'F'),
			new Person("Vivianne","Dexter", 19, 'F' ),
			new Person("Bob","Smith", 49, 'M' ),
			new Person("Brett","Baker", 51, 'M' ),
			new Person("Mark","Parker", 19, 'M'),
			new Person("Alice","Thompson", 18, 'F'),
			new Person("Evelyn","Thompson", 58, 'F' ),
			new Person("Mort","Martin", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			};


			// Task 01
			// all people aged 50 or more
			Console.WriteLine("Peple older than 50");

			List<string> aged50OrMore = people
									.Where(x => x.Age >= 50)
									.Select(x => x.FirstName)
									.ToList();
			aged50OrMore.ForEach(x => Console.WriteLine(x));



			// Task 02
			// all people name starts with B
			Console.WriteLine("Name starts with B");

			List<Person> nameStartsWithB = people
										.Where(x => x.FirstName.StartsWith("B"))
										.ToList();
			nameStartsWithB.ForEach(x => Console.WriteLine(x.FirstName));

			// Task 03
			// first person whose surname starts with T
			Console.WriteLine("Surname starts with T");
			List<Person> surnameWithT = people
										.Where(x => x.LastName.StartsWith("T"))
										.ToList();
			surnameWithT.ForEach(x => Console.WriteLine(x.LastName));

			// Task 04
			// find youngest and oldest person
			Console.WriteLine("Youngest and oldest");
			var youngest = people
								.Where(x => x.Age == people.Select(x => x.Age).Min())
								.FirstOrDefault();

			var oldest = people
								.Where(x => x.Age == people.Select(x => x.Age).Max())
								.FirstOrDefault();
			Console.WriteLine($"Youngest: {youngest.FirstName} | Oldest: {oldest.FirstName}");
			// Task 05
			// find all male people aged 45 or more
			Console.WriteLine("All males over 45 years");
			List<string> maleOver45 = people
										.Where(x => x.Age > 45 && x.Gender == 'M')
										.Select(x => x.FirstName)
										.ToList();
			maleOver45.ForEach(x => Console.WriteLine(x));
			// Task 06
			// find all females whose name starts with V
			Console.WriteLine("All females whose name starts with V");
			List<string> femaleNameV = people
										.Where(x => x.FirstName.Substring(0, 1) == "V" && x.Gender == 'F')
										.Select(x => x.FirstName)
										.ToList();
			femaleNameV.ForEach(x => Console.WriteLine(x));
			

			// Task 07
			// find last female person older than 30 whose name starts with p
			Console.WriteLine("Last female older than 30 whose name starts with P");
			Person lastFemaleP = people
										  .LastOrDefault(x => x.Age > 30 && x.Gender == 'F' && x.FirstName.StartsWith("P"));
            if (lastFemaleP == null)
            {
                Console.WriteLine("No such person");
            }
            else Console.WriteLine(lastFemaleP.FirstName);

			// Task 08
			// find first male younger than 40
			Console.WriteLine("First male younger than 40");

			Person firstMaleYoungerThan40 = people
										  .FirstOrDefault(x => x.Age < 40 && x.Gender == 'M'); ;
			if (firstMaleYoungerThan40 == null)
			{
				Console.WriteLine("No such person");
			}
			else Console.WriteLine(firstMaleYoungerThan40.FirstName);


			// Task 09
			// print the names of the male persons that have firstName longer than lastName

			Console.WriteLine("Males with name longer than surname");
			List<string> maleNameLonger = people
										.Where(x => x.Gender == 'M' && x.FirstName.Length > x.LastName.Length)
										.Select(x => x.FirstName)
										.ToList();
			if (maleNameLonger.Count == 0)
            {
                Console.WriteLine("No such person");
            } 
			else maleNameLonger.ForEach(x => Console.WriteLine(x));

			// Task 10
			// print the lastNames of the female persons that have odd number of ages
			Console.WriteLine("Females with odd number of years");
			List<string> femaleLastNameOddYears = people
										.Where(x => x.Age % 2!=0 && x.Gender == 'F')
										.Select(x => x.LastName)
										.ToList();
			femaleLastNameOddYears.ForEach(x => Console.WriteLine(x));


			Console.ReadLine();
		}
	}
}
