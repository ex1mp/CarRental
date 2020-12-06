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
        private ICarBody carBody;
        private IEngine carEngine;
        private double consumptionOfFuel;
        private double maxSpeed;
        private double carCost;
        private int carID;
        private string carModel;
        public Car(IEngine engine, ICarBody body,double carCost,string model,int ID)
        {
            carBody = body;
            carEngine = engine;
            CarCost = carCost;
            CarModel = model;
            carID = ID;
            ConsumptionOfFuel = GetConsumption(engine,body);
            MaxSpeed= GetMaxSpeed(engine, body);
        }

        public double ConsumptionOfFuel { get => consumptionOfFuel;private set => consumptionOfFuel = value; }
        public double MaxSpeed { get => maxSpeed; private set => maxSpeed = value; }
        public double CarCost { get => carCost; set => carCost = value; }
        public int CarID { get => carID; private set => carID = value; }
        public string CarModel { get => carModel; set => carModel = value; }
        internal ICarBody CarBody { get => carBody; private set => carBody = value; }
        internal IEngine CarEngine { get => carEngine; private  set => carEngine = value; }

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
            Console.WriteLine("Car ID: {0}; \r\n Model of car: {1};\r\n Max speed: {3}; \r\n Consumption of fuel: {4} \r\n Price: {5} ",carID, carModel, maxSpeed, consumptionOfFuel, carCost);
        }

    }
}
