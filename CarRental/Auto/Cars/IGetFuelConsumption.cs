﻿using CarRental.CarBody;
using CarRentalCarRental.Engines;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Auto.Cars
{
    interface IGetFuelConsumption
    {
        public double GetConsumption(IEngine engine,ICarBody carBody);
    }
}
