using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    class CarRent
    {
        private CarCreator crCar;
        private AutoLibrary autoLib;
        public CarRent()
        {
            crCar = new CarCreator();
            autoLib = new AutoLibrary();
            Menu();
        }
        public void Menu()
        {
            Console.WriteLine(" Welcome to the taxi company menu. What would you like to do?\r\n Choose one of the options below: ");
            Console.WriteLine(" 1. Add car \r\n 2. Delite car \r\n 3. Find a car by speed params \r\n 4. Get tax station cost \r\n 5. Show a list of cars sorted by cost to overcome every 100 km");
            
            switch (InputValidation("Choose one of the items above"))
            {
                case 1: autoLib.AddCar(crCar.CreateCar());
                    break;
                default: break;
            }
        }
        private int InputValidation(string message)
        {
            bool result = false;
            int item = 0;
            while (!result)
            {
                //в отдельный метод
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
