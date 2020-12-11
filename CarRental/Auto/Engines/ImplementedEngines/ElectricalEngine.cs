using CarRentalCarRental.Engines;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Engines.ImplementedEngines
{
    class ElectricalEngine : IEngine
    {
        public double Capacity { get => Capacity; private set => Capacity = value; }
    }
}
