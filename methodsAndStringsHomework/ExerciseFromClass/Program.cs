using System;

namespace ExerciseFromClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.AddDays(3));
            Console.WriteLine(DateTime.Now.AddMonths(1));
            Console.WriteLine(DateTime.Now.AddDays(3).AddMonths(1));
            Console.WriteLine(DateTime.Now.AddMonths(-2).AddYears(-1));
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
        }
    }
}
