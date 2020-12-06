using CarRental.Auto;
using CarRental.CarBody;
using CarRental.CarBody.ImplementedBodys;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    class CarCreator
    {
        public void CreateCar()
        {
            double carCost;
            string model;
            bool result=false;
            ICarBody bodyCar;

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
                default:
                    break;
            }


        }
    }
}
