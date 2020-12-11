using CarRental.Auto;
using CarRental.Auto.CarBody.ImplementedBodys;
using CarRental.Auto.Cars.ImplementingClasses;
using CarRental.CarBody;
using CarRental.Engines.ImplementedEngines;
using CarRental.Engines.ImplementedEngines.InternalCombustionSubclasses;
using CarRentalCarRental.Engines;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.MainControl.Services
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
        private void InputValidation(bool result,string message,ref int item,int minVal,long maxVal)
        {
            while (!result)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                result = int.TryParse(input, out item);
                if (!result||item<minVal||item>maxVal)
                {
                    Console.WriteLine("Invalid value, please try again");
                    result = false;
                }

            }
        }

        public Car CreateCar()
        {
            int carCost=0;
            string model;
            bool result=false;
            int nummberOfBody = 0;
            int nummberOfEngine = 0;
            ICarBody bodyCar;
            IEngine engineCar;
            string enterTheCost = "Enter the cost of the car";
            string choseTheBody = "Choose a car body \r\n 1.Coupe \r\n 2.Hatchback \r\n 3.Minivan ";
            string choseTheEngine = "Choose a car engine \r\n 1.DieselEngine \r\n 2.ElectricalEngine \r\n 3.GasolineEngine ";
            Console.WriteLine("Enter the name of the car");
            model = Console.ReadLine();
            InputValidation(result, enterTheCost,ref carCost,0, 9223372036854000000);
            InputValidation(result, choseTheBody,ref nummberOfBody,1,3);

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

            InputValidation(result, choseTheEngine, ref nummberOfEngine,1,3);


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
            return new Car(engineCar, bodyCar, carCost, model, IdOfCar);

        }
    }
}
