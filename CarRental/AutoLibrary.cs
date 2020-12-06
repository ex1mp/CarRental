using System;
using System.Collections.Generic;
using System.Text;
using CarRental.Auto;

namespace CarRental
{
    class AutoLibrary
    {
        private List<Car> carLib;

        internal List<Car> CarLib { get => carLib; set => carLib = value; }

        public AutoLibrary(List<Car> carLib)
        {
            CarLib = carLib;
        }

        public AutoLibrary()
        {
            CarLib = new List<Car>();
        }

        public void AddCar(Car car)
        {
            carLib.Add(car);
        }
        public Car FindCar(int carID)
        {
            foreach (Car car in carLib)
            {
                if (car.CarID == carID)
                {
                    carLib.Remove(car);
                    return car;
                }
            }
            return null;
        }
        public bool DeliteCar(int carID)
        {
            foreach (Car  car in carLib)
            {
                if (car.CarID==carID)
                {
                    carLib.Remove(car);
                    return true;
                }
            }
            return false;
        }
    }
}
