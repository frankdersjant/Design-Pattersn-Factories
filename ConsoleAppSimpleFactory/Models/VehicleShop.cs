using ConsoleAppSimpleFactory.Models.Interfaces;

namespace ConsoleAppSimpleFactory.Models
{
    public class VehicleShop
    {
        private IVehicleFactory _vehicleFactory;

        public VehicleShop(IVehicleFactory vehicleFactory)
        {
            _vehicleFactory = vehicleFactory;
        }

        public IVehicle OrderVehicle(string type)
        {
            return _vehicleFactory.CreateVehicle(type);
        }
    }
}
