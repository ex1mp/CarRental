using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CarCreator cr = new CarCreator();
            cr.CreateCar();
        }
    }
}
