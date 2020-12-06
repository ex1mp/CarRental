using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.CarBody.ImplementedBodys
{
    class Hatchback:ICarBody
    {
        public string BodyMaterial { get => BodyMaterial; private set => BodyMaterial = value; }
    }
}
