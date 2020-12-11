using CarRentalCarRental.Engines;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Engines.ImplementedEngines
{
    abstract class InternalCombustionEngine:IEngine
    {
        public double EnginePower { get => EnginePower; private set => EnginePower = value; }
        public double Capacity { get => Capacity; private set => Capacity = value; }
    }
}
