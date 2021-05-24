using ConsoleAppSimpleFactory.Models.Interfaces;
using System;

namespace ConsoleAppSimpleFactory.Models
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "bike":
                    return new Bike();
                case "scooter":
                    return new Scooter();
                default:
                    throw new ArgumentException();
                    throw new NotImplementedException();
            }
        }
    }
}
