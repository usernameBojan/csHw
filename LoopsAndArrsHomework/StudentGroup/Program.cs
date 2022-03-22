using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "John Doe", "John Smith", "Bob Bobsky", "Jane Doe", "Jane Smith" };
            string[] studentsG2 = { "Jovan Kovachev", "Jan Kowalski", "Johann Schmidt", "Jan Schmitzer", "Joan Ferrer" };

            Console.WriteLine("Which group of students would you like to get info for?");
            int userInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                if (userInput == 1)
                {
                    Console.WriteLine((i + 1) + ". " + studentsG1[i]);
                }
                else if (userInput == 2)
                {
                    Console.WriteLine((i + 1) + ". " + studentsG2[i]);
                }
                else
                {
                    Console.WriteLine("No such group.");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}