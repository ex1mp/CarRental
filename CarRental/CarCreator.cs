using CarRental.Auto;
using CarRental.CarBody;
using CarRental.CarBody.ImplementedBodys;
using CarRental.Engines.ImplementedEngines;
using CarRentalCarRental.Engines;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    class CarCreator
    {
        static private int idOfCar=0;

        private int IdOfCar
        {
            get
            {
                idOfCar++;
                return idOfCar;
            }
        }

        public Car CreateCar()
        {
            double carCost=0;
            string model;
            bool result=false;
            ICarBody bodyCar;
            IEngine engineCar;

            Console.WriteLine("Enter the name of the car");
            model = Console.ReadLine();

            while (!result)
            {
                Console.WriteLine("Enter the cost of the car");
                string input = Console.ReadLine();
                result = double.TryParse(input, out carCost);
                if(!result)
                {
                    Console.WriteLine("Invalid value, please try again");
                }
    
            }

            result = false;
            int nummberOfBody=0;

            while (!result)
            {
                Console.WriteLine("Choose a car body \r\n 1.Coupe \r\n 2.Hatchback \r\n 3.Minivan ");
                string input = Console.ReadLine();
                result = int.TryParse(input, out nummberOfBody);
                if (!result)
                {
                    Console.WriteLine("Invalid value, please try again");
                }

            }

            switch (nummberOfBody)
            {
                case 1: bodyCar = new Coupе(); ;
                    break;
                case 2:
                    bodyCar = new Hatchback(); ;
                    break;
                case 3:
                    bodyCar = new Minivan(); ;
                    break;
                default: bodyCar = null;
                    break;
            }

            result = false;
            int nummberOfEngine = 0;

            while (!result)
            {
                Console.WriteLine("Choose a car engine \r\n 1.DieselEngine \r\n 2.ElectricalEngine \r\n 3.GasolineEngine ");
                string input = Console.ReadLine();
                result = int.TryParse(input, out nummberOfEngine);
                if (!result)
                {
                    Console.WriteLine("Invalid value, please try again");
                }

            }

            switch (nummberOfEngine)
            {
                case 1:
                    engineCar = new DieselEngine(); ;
                    break;
                case 2:
                    engineCar = new ElectricalEngine(); ;
                    break;
                case 3:
                    engineCar = new GasolineEngine(); ;
                    break;
                default:
                    engineCar = null;
                    break;
            }
            Console.WriteLine();
            return new Car(engineCar, bodyCar, carCost, model, idOfCar);

        }
    }
}
