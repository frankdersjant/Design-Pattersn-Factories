namespace ConsoleAppSimpleFactory.Models.Interfaces
{
    public interface IVehicleFactory
    {
         IVehicle CreateVehicle(string vehicleType);
    }
}
