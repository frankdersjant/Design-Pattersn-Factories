using ConsoleAppSimpleFactory.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
