using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");
            int userInputNum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int userInputNum2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your third number");
            int userInputNum3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your fourth number");
            int userInputNum4 = int.Parse(Console.ReadLine());
            int sum = userInputNum1 + userInputNum2 + userInputNum3 + userInputNum4;
            int avg = sum / 4;
            Console.WriteLine("Average of " + userInputNum1 + ", " + userInputNum2 + ", " + userInputNum3 + " and " + userInputNum4 + " is " + avg);
            Console.ReadLine();
        }
    }
}