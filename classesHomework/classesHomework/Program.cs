using classesHomework.Models;
using System;

namespace classesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver Default = new Driver("default", 0, 0);
            Driver Verstappen = new Driver("Max Verstappen", 5, 0);
            Driver Hamilton = new Driver("Lewis Hamilton", 5, 0);
            Driver Bottas = new Driver("Valtteri Bottas", 4, 0);
            Driver Leclerc = new Driver("Charles Leclerc", 3, 0);
            Car Mercedes = new Car("Mercedes", Default, 300, 0);
            Car Ferrari = new Car("Ferrari", Default, 320, 0);
            Car RedBull = new Car("RedBull Powertrains", Default, 280, 0);
            Car Renault = new Car("Renault", Default, 260, 0);

            ChooseOptions();

            static void RaceCars(Car firstCar, Car secondCar)
            {
                int speed1 = firstCar.CalculateSpeed(firstCar, firstCar.Driver);
                int speed2 = secondCar.CalculateSpeed(firstCar, secondCar.Driver);

                if (speed1 > speed2)
                {
                    Console.WriteLine($"{firstCar.Model} won the race. It was going {firstCar.Speed} and was driven by {firstCar.Driver.Name}");
                }
                else if (speed2 > speed1)
                {
                    Console.WriteLine($"{secondCar.Model} won the race. It was going {secondCar.Speed} and was driven by {secondCar.Driver.Name}");
                }
                else Console.WriteLine("We have a draw!");
            }

            void ChooseOptions()
            {
                Car[] cars = { Mercedes, Ferrari, RedBull, Renault };
                Driver[] drivers = { Verstappen, Hamilton, Bottas, Leclerc };
                string[] carOpts = { $"1.{Mercedes.Model}", $"2.{Ferrari.Model}", $"3.{RedBull.Model}", $"4.{Renault.Model}" };
                string[] driverOpts = { $"1.{Verstappen.Name}", $"2.{Hamilton.Name}", $"3.{Bottas.Name}", $"4.{Leclerc.Name}" };
                Car car1 = default;
                Car car2 = default;

                void chooseOpts(string selectValue, string choiceValue, int secondChoice)
                {
                    for(int i=0; i<4; i++)
                    {
                        if (selectValue == carOpts[i].Substring(0, 1) && choiceValue == "Car" && secondChoice == 0)
                        {
                            car1 = cars[i];
                            car1.Id = i+1;
                        }
                        if (selectValue == driverOpts[i].Substring(0, 1) && choiceValue == "Driver" && secondChoice == 0)
                        {
                            car1.Driver = drivers[i];
                            car1.Driver.Id = i+1;
                        }
                        if (selectValue == carOpts[i].Substring(0, 1) && choiceValue == "Car" && secondChoice == 2)
                        {
                            car2 = cars[i];
                            car2.Id = i+1;
                        }                        
                        if (selectValue == driverOpts[i].Substring(0, 1) && choiceValue == "Driver" && secondChoice == 2)
                        {
                            car2.Driver = drivers[i];
                            car2.Driver.Id = i+1;
                        } 
                        else if (selectValue!="1" && selectValue != "2" && selectValue != "3" && selectValue != "4")
                        {
                            Console.WriteLine("Error. No such driver. Please select one of the offered numbers");
                            ChooseOptions();
                        }
                    }
                }

                Console.WriteLine($"Choose your first car by typing its number: \n {carOpts[0]} \n {carOpts[1]} \n {carOpts[2]} \n {carOpts[3]}");
                string selectFirstCar = Console.ReadLine();
                chooseOpts(selectFirstCar, "Car", 0);

                Console.WriteLine($"Choose a driver for your first car by typing its number: \n {driverOpts[0]} \n {driverOpts[1]} \n {driverOpts[2]} \n {driverOpts[3]}");
                string selectFirstDriver = Console.ReadLine();
                chooseOpts(selectFirstDriver, "Driver", 0);
                
                void printWithoutFirst(bool carOrDriver)
                {
                    if (carOrDriver)
                    {
                        for (int i = 0; i < carOpts.Length; i++)
                        {
                            if ($"{(i + 1)}.{car1.Model}" != carOpts[i])
                            {
                                Console.WriteLine(carOpts[i]);
                            }
                        }
                    } 
                   else
                    {
                        for (int i = 0; i < driverOpts.Length; i++)
                        {
                            if ($"{(i + 1)}.{car1.Driver.Name}" != driverOpts[i])
                            {
                                Console.WriteLine(driverOpts[i]);
                            }
                        }
                    }           
                }

                Console.WriteLine("Choose your second car by typing its number:");
                printWithoutFirst(true);
                string selectSecondCar = Console.ReadLine();
                if (selectSecondCar == Convert.ToString(car1.Id))
                {
                    if (int.Parse(selectSecondCar) == 4) 
                    {
                        int nextChoice = (int.Parse(selectSecondCar)) - 1;
                        chooseOpts(Convert.ToString(nextChoice), "Car", 2);
                        Console.WriteLine("You already choose that option. Previous car was assigned as your second choice.");
                    } 
                    else
                    {
                        int nextChoice = (int.Parse(selectSecondCar)) + 1;
                        chooseOpts(Convert.ToString(nextChoice), "Car", 2);
                        Console.WriteLine("You already choose that option. Next car was assigned as your second choice.");
                    }
                }
                else chooseOpts(selectSecondCar, "Car", 2);
                
                Console.WriteLine("Choose your second driver by typing its number:");
                printWithoutFirst(false);
                string selectSecondDriver = Console.ReadLine();
                if (selectSecondDriver == Convert.ToString(car1.Driver.Id))
                {
                    if (int.Parse(selectSecondDriver) == 4)
                    {
                        int nextChoiceDriver = (int.Parse(selectSecondDriver)) - 1;
                        chooseOpts(Convert.ToString(nextChoiceDriver), "Driver", 2);
                        Console.WriteLine("You already choose that option. Previous driver was assigned as your second choice." + nextChoiceDriver);
                    }
                    else
                    {
                        int nextChoiceDriver = (int.Parse(selectSecondDriver)) + 1;
                        chooseOpts(Convert.ToString(nextChoiceDriver), "Driver", 2);
                        Console.WriteLine("You already choose that option. Next driver was assigned as your second choice." + nextChoiceDriver);
                    }
                }
                else chooseOpts(selectSecondDriver, "Driver", 2);

                RaceCars(car1, car2);
                Console.WriteLine("Would you like another race? type Y/N.");
                string raceAgainAnswer = Console.ReadLine().ToLower();
                if (raceAgainAnswer == "y")
                {
                    ChooseOptions();
                }
                else if (raceAgainAnswer != "y")
                {
                    Environment.Exit(0);
                }
            }   
        }
    }
}
