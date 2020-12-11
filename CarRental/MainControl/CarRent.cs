using CarRental.Auto;
using CarRental.Auto.CarBody;
using CarRental.Auto.Cars.ImplementingClasses;
using CarRental.Auto.DataStorage;
using CarRental.MainControl.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.MainControl
{
    class CarRent
    {
        private CarCreator crCar;
        private AutoLibrary autoLib;
        public CarRent()
        {
            crCar = new CarCreator();
            autoLib = new AutoLibrary();
            MainMenu();
        }
        public CarRent(List<Car> carLb)
        {
            crCar = new CarCreator();
            autoLib = new AutoLibrary(carLb);
            MainMenu();
        }
        public void MainMenu()
        {
            bool isContine= true;
            Console.WriteLine(" Welcome to the taxi company menu. ");
            while (isContine)
            {
                Menu(ref isContine);
            }

        }
        public void Menu(ref bool isContine)
        {
            Console.WriteLine(" Choose one of the options below: ");
            Console.WriteLine(" 1. Add car \r\n 2. Delite car \r\n 3. Find a car by speed params \r\n 4. Get tax station cost \r\n 5. Show a list of cars sorted by cost to overcome every 100 km \r\n 6. Exit");
            
            switch (InputValidation("Choose one of the items above"))
            {
                case 1: autoLib.AddCar(crCar.CreateCar());
                    break;
                case 2: autoLib.DeliteCar(InputValidation("Enter the id of the car you want to delete"));
                    break;
                case 3: List<Car> cLst = autoLib.FindCarBySpeed(InputValidation("Enter the required maximum vehicle speed"));
                    foreach (Car item in cLst)
                    {
                        Console.WriteLine(item.GetCarInfo());
                    }
                    break;
                case 4: Console.WriteLine(autoLib.GetTaxStationCost()); 
                    break;
                case 5:
                    List<Car> cLsit = autoLib.SortByConsumption();
                    foreach (Car item in cLsit)
                    {
                        Console.WriteLine(item.GetCarInfo());
                    };
                    break;
                case 6: isContine = false; 
                    break;
                default:
                    Console.WriteLine(" Command not recognized, please try again.");
                    break;
            }
        }
        private int InputValidation(string message)
        {
            bool result = false;
            int item = 0;
            while (!result)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                result = int.TryParse(input, out item);
                if (!result)
                {
                    Console.WriteLine("Invalid value, please try again");
                }
                return item;

            }
            return 0;

        }

    }
}
