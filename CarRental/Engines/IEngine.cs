using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalCarRental.Engines
{
    interface IEngine
    {
        public double capacity { get => capacity; private set => capacity = value; }
    }
}
