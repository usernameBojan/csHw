using System;

namespace ageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool control;
            string wrongInptMsg = "Wrong format. Please insert your date of birth like this: " +
                    "\n15.05.1995 or 08/08/2008 or 03-11-1987 \nWith separating sign and zeros no matter the number. \n";
            
            do
            {
                Console.WriteLine("Write your Birthday in the following format dd/mm/yy:");
                string dateOfBirth = Console.ReadLine();
                if (dateOfBirth.Length != 10 || int.Parse(dateOfBirth.Substring(0, 2)) > 31 || int.Parse(dateOfBirth.Substring(3, 2)) > 12)
                {
                    control = false;
                    Console.WriteLine(wrongInptMsg);
                }
                else 
                {
                    Console.WriteLine(CalculateAge(dateOfBirth));
                    break;
                };
            } while (control == false);

            Console.ReadLine();
        }

        static int CalculateAge(string birthDate)
        {
            int age = 0;
            int dateOfBirth = int.Parse(birthDate.Substring(0, 2));
            int monthOfBirth = int.Parse(birthDate.Substring(3, 2));
            int yearOfBirth = int.Parse(birthDate.Substring(6, 4));
            int dateNow = int.Parse(DateTime.Now.Day.ToString());
            int monthNow = int.Parse(DateTime.Now.Month.ToString());
            int yearNow = int.Parse(DateTime.Now.Year.ToString());

            if (monthOfBirth > monthNow)
            {
                age = yearNow - yearOfBirth-1;
            }
            else if (monthOfBirth == monthNow && dateOfBirth > dateNow)
            {
                age = yearNow - yearOfBirth-1;
            }
            else if (monthOfBirth < monthNow)
            {
                age = yearNow - yearOfBirth;
            }
            else if (monthOfBirth == monthNow && dateOfBirth <= dateNow)
            {
                age = yearNow - yearOfBirth;
            }
            return age;
        }

    }
}
