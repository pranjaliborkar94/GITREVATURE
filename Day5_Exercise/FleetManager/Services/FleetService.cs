using FleetManager.Core;

namespace FleetManager.Services
{
    public class FleetService
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void StartAllVehicles()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.Start(); // polymorphism
            }
        }
    }
}
