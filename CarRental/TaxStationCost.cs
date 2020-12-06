using CarRental.Auto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    class TaxStationCost
    {
        public double GetTaxStationCost (List<Car> listOfCars)
        {
            double taxStationCost=0;
            foreach (Car item in listOfCars)
            {
                taxStationCost += item.CarCost;
            }
            return taxStationCost;
        }
    }
}
