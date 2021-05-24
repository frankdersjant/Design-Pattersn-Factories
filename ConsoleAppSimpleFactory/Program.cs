using ConsoleAppSimpleFactory.Models;
using ConsoleAppSimpleFactory.Models.Interfaces;

namespace ConsoleAppSimpleFactory
{
    class Program
    {
        public static object IVehicleShop { get; private set; }

        static void Main(string[] args)
        {
            IVehicleFactory vehicleFactory = new VehicleFactory();

            VehicleShop vehicleShop = new VehicleShop(vehicleFactory);

            IVehicle vehicle = vehicleShop.OrderVehicle("bike");
            vehicle.Drive(145);
        }
    }
}
