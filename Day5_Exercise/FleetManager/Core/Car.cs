using FleetManager.Interfaces;

namespace FleetManager.Core
{
    public class Car : Vehicle, IMaintainable, ITrackable
    {
        public Car(string make, string model, double fuel)
            : base(make, model, fuel) { }

        public override void Start()
        {
            Console.WriteLine($"Car {Make} started.");
        }

        // Explicit interface implementation
        void IMaintainable.ScheduleMaintenance()
        {
            Console.WriteLine($"Car {Make} maintenance scheduled.");
        }

        string ITrackable.GetLocation()
        {
            return $"Car {Make} location: Mumbai";
        }
    }
}
