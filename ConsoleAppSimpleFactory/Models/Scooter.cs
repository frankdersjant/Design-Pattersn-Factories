using ConsoleAppSimpleFactory.Models.Interfaces;
using System;

namespace ConsoleAppSimpleFactory.Models
{
    public class Scooter : IVehicle
    {
        public void Drive(int speed)
        {
            Console.WriteLine("Driving slowly ", + speed);
        }
    }
}
