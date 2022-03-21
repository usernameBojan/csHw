using System;

namespace methodsAndStringsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Write your Birthday in the following format dd/mm/yy");
            string dateOfBirth = Console.ReadLine();
            string month = dateOfBirth.Substring(3, 4);
            Console.WriteLine(month);
        }

        static void FunWithString(string inputParam)
        {

        }
    }
}
