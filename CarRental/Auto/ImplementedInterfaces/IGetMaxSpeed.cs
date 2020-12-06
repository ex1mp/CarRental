using CarRental.CarBody;
using CarRentalCarRental.Engines;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Auto.ImplementedInterfaces
{
    interface IGetMaxSpeed
    {
        public double GetMaxSpeed(IEngine engine, ICarBody body);
    }
}
