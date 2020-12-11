using CarRental.CarBody;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Auto.CarBody.ImplementedBodys
{
    class Coupе:ICarBody
    {
        public string BodyMaterial { get => BodyMaterial; private set => BodyMaterial = value; }
    }
}
