using System;
using InhertienceHomework.classes;
namespace InhertienceHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ZastavaSkala = new Car(90, 5, 140, EngineType.CNG);
            ZastavaSkala.Model = "Skala";
            ZastavaSkala.Manufacturer = "Zastava";
            ZastavaSkala.PrintInfo();

            Car OpelMeriva = new Car(100, 5, 220, EngineType.Diesel);
            OpelMeriva.Model = "Meriva";
            OpelMeriva.Manufacturer = "Opel";
            OpelMeriva.PrintInfo();

            Car AudiQ7 = new Car(88, 5, 260, EngineType.Petrol);
            AudiQ7.Model = "Q7";
            AudiQ7.Manufacturer = "Audi";
            AudiQ7.PrintInfo();

            Car FerrariPortofino = new Car(105, 2, 320, EngineType.Petrol);
            FerrariPortofino.Model = "Portofino";
            FerrariPortofino.Manufacturer = "Ferrari";
            FerrariPortofino.PrintInfo();

            ElectricCar TeslaY = new ElectricCar(75, 100);
            TeslaY.Model = "Model Y";
            TeslaY.Manufacturer = "Tesla";
            TeslaY.MaxSpeed = 250;

            ElectricCar TeslaX = new ElectricCar(100, 100);
            TeslaX.Model = "Model X";
            TeslaX.Manufacturer = "Tesla";
            TeslaX.MaxSpeed = 250;

            ElectricCar PorscheTaycan = new ElectricCar(79, 100);
            PorscheTaycan.Model = "Taycan";
            PorscheTaycan.Manufacturer = "Porsche";
            PorscheTaycan.MaxSpeed = 260;

            Bicyle SculturaEndurance = new Bicyle(12, false);
            SculturaEndurance.Model = "SCULTURA ENDURANCE 9000";
            SculturaEndurance.Manufacturer = "Merida";

            Bicyle eScultura = new Bicyle(1, true);
            eScultura.Model = "eSCULTURA 400";
            eScultura.Manufacturer = "Merida";
        }
    }
}
