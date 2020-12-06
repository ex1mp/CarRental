using CarRentalCarRental.Engines;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Engines.ImplementedEngines
{
    class GasolineEngine:IEngine
    {
        public double capacity { get => capacity; private set => capacity = value; }
    }
}
