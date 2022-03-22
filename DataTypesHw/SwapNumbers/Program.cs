using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int userInputNum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int userInputNum2 = int.Parse(Console.ReadLine());

            userInputNum1 = userInputNum1 + userInputNum2;
            userInputNum2 = userInputNum1 - userInputNum2;
            userInputNum1 = userInputNum1 - userInputNum2;

            Console.WriteLine("First number:" + userInputNum1);
            Console.WriteLine("Second number:" + userInputNum2);

            Console.ReadLine();
        }
    }
}