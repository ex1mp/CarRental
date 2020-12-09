using CarRental.CarBody;
using CarRentalCarRental.Engines;
using System;
using System.Collections.Generic;
using System.Text;
using CarRental.Auto.ImplementedInterfaces;

namespace CarRental.Auto
{
    class Car : IGetFuelConsumption, IGetMaxSpeed
    {
        public ICarBody СarBody { get; private set; }
        public IEngine СarEngine { get; private set; }
        public double ConsumptionOfFuel { get; private set; }
        public double MaxSpeed { get; private set; }
        public int CarCost { get; private set; }
        public string CarModel { get; private set; }
        public int CarID { get; private set; }

        public Car(IEngine engine, ICarBody body,int carCost,string model,int ID)
        {
            СarBody = body;
            СarEngine = engine;
            CarCost = carCost;
            CarModel = model;
            CarID = ID;
            ConsumptionOfFuel = GetConsumption(engine,body);
            MaxSpeed= GetMaxSpeed(engine, body);
        }

        public double GetConsumption(IEngine engine, ICarBody body)
        {
            double consumption=0;
            //here the fuel consumption is somehow calculated taking into account the parameters of the body and engine
            return consumption;
        }
        public double GetMaxSpeed(IEngine engine, ICarBody body)
        {
            double maxSpeed = 0;
            //here the maximum car speed is somehow calculated taking into account the parameters of the body and engine
            return maxSpeed;
        }
        public void GetCarInfo()
        {
            Console.WriteLine("Car ID: {0}; \r\n Model of car: {1};\r\n Max speed: {3}; \r\n Consumption of fuel: {4} \r\n Price: {5} ",CarID, CarModel, MaxSpeed, ConsumptionOfFuel, CarCost);
        }

    }
}
