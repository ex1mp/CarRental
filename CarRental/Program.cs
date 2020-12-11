using CarRental.Auto;
using CarRental.Auto.CarBody.ImplementedBodys;
using CarRental.Auto.Cars.ImplementingClasses;
using CarRental.Engines.ImplementedEngines;
using CarRental.MainControl;
using CarRental.MainControl.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    class Program
    {
        static private List<Car> CarGenerator(int counOfCars)
        {
            var lCar = new List<Car>();
            var rand = new Random();
            for (int i = 0; i < counOfCars; i++)
            {
                lCar.Add(new Car(new ElectricalEngine(), new Coupе(), rand.Next(0, 500000000), rand.Next(0, 6465464).ToString(), i+1000));
            }
            return lCar;
        }
        static void Main(string[] args)
        {

            
            CarRent rt = new CarRent(CarGenerator(100));
        }
    }
}
