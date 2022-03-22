using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOfNums = new int[6];
            int sum = 0;

            for (int i = 0; i < arrOfNums.Length; i++)
            {
                Console.WriteLine("Enter number " + (i + 1) + ":");
                arrOfNums[i] = int.Parse(Console.ReadLine());
                if (arrOfNums[i] % 2 == 0)
                {
                    sum += arrOfNums[i];
                }
            }
            Console.WriteLine("Sum of even numbers is: " + sum);
            Console.ReadLine();
        }
    }
}