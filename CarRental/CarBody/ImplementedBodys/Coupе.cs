using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.CarBody.ImplementedBodys
{
    class Coupе:ICarBody
    {
        public string BodyMaterial { get => BodyMaterial; private set => BodyMaterial = value; }
    }
}
