using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number");
            int userInputNum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int userInputNum2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Which operation you would like to perform?");
            string userInputChar = Console.ReadLine();
            int result;
            switch (userInputChar)
            {
                case "+":
                    result = userInputNum1 + userInputNum2;
                    Console.WriteLine("Result is " + result);
                    break;
                case "-":
                    result = userInputNum1 - userInputNum2;
                    Console.WriteLine("Result is " + result);
                    break;
                case "*":
                    result = userInputNum1 * userInputNum2;
                    Console.WriteLine("Result is " + result);
                    break;
                case "/":
                    result = userInputNum1 / userInputNum2;
                    Console.WriteLine("Result is " + result);
                    break;
                default:
                    Console.WriteLine("No such operation. You can only choose +, -, * and /.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
