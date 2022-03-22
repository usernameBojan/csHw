using System;

namespace SumOfEvenDifferentApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fourth number:");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fifth number:");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sixth number:");
            int num6 = int.Parse(Console.ReadLine());
            int[] arrOfNums = { num1, num2, num3, num4, num5, num6 };
            int sum = 0;
            for (int i = 0; i < arrOfNums.Length; i++)
            {
                if (arrOfNums[i] % 2 == 0)
                {
                    sum += arrOfNums[i];
                }
            }
            Console.WriteLine("Sum of evens is " + sum);
            Console.ReadLine();
        }
    }
}