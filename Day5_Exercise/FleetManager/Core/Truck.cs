using FleetManager.Interfaces;

namespace FleetManager.Core
{
    public class Truck : Vehicle, IMaintainable, ITrackable
    {
        public Truck(string make, string model, double fuel)
            : base(make, model, fuel) { }

        public override void Start()
        {
            Console.WriteLine($"Truck {Make} heavy engine started.");
        }

        void IMaintainable.ScheduleMaintenance()
        {
            Console.WriteLine($"Truck {Make} maintenance scheduled.");
        }

        string ITrackable.GetLocation()
        {
            return $"Truck {Make} location: Pune";
        }
    }
}
