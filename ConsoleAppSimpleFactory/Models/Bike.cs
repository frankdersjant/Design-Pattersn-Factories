using ConsoleAppSimpleFactory.Models.Interfaces;
using System;

namespace ConsoleAppSimpleFactory.Models
{
    public class Bike : IVehicle
    {
        public void Drive(int speed)
        {
            Console.WriteLine("Driving fast " + speed);
        }
    }
}
