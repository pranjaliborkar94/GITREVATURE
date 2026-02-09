using FleetManager.Core;
using FleetManager.Interfaces;
using FleetManager.Services;

namespace FleetManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Fleet Manager ===");

            FleetService fleetService = new FleetService();

            // Creating vehicles
            Vehicle car = new Car("Toyota", "Innova", 50);
            Vehicle truck = new Truck("Tata", "Ultra", 80);

            fleetService.AddVehicle(car);
            fleetService.AddVehicle(truck);

            // Polymorphism demo
            Console.WriteLine("\n--- Starting Vehicles ---");
            fleetService.StartAllVehicles();

            // Interface usage
            Console.WriteLine("\n--- Maintenance ---");
            IMaintainable maintainable = (IMaintainable)car;
            maintainable.ScheduleMaintenance();

            Console.WriteLine("\n--- Tracking ---");
            ITrackable trackable = (ITrackable)truck;
            Console.WriteLine(trackable.GetLocation());

            Console.WriteLine("\n--- Fuel Update ---");
            car.Refuel(20);
            truck.ConsumeFuel(30);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
