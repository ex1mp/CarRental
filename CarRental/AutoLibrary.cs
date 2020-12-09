using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<Car> FindCar(double maxSpeed)
        {
            List<Car> carsBySpeed = new List<Car>();
            foreach (Car car in CarLib)
            {
                if (car.MaxSpeed >= maxSpeed)
                {
                    carsBySpeed.Add(car);
                }
            }
            return carsBySpeed;
        }
        public double GetTaxStationCost()
        {
            double taxStationCost = 0;
            foreach (Car item in CarLib)
            {
                taxStationCost += item.CarCost;
            }
            return taxStationCost;
        }
        public List<Car> SortByConsumption(List<Car> listOfCars)
        {
            return listOfCars.OrderBy(o => o.ConsumptionOfFuel).ToList();
        }
    }
}
