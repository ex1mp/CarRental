using CarRental.Auto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    class FindCarBySpeed
    {
       public List<Car> FindCar(double maxSpeed,List<Car> listOfCars)
        {
            List<Car> carsBySpeed = new List<Car>();
            foreach (Car car in listOfCars)
            {
                if(car.MaxSpeed>= maxSpeed)
                {
                    carsBySpeed.Add(car);
                }
            }
            return carsBySpeed;
        }
    }
}
