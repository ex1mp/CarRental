using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalCarRental.Engines
{
    interface IEngine
    {
        public double EnginePower { get => EnginePower; private set => EnginePower = value; }
    }
}
