namespace FleetManager.Core
{
    public abstract class Vehicle
    {
        private double _fuelLevel;

        public int Id { get; }
        public string Make { get; set; }
        public string Model { get; set; }

        public double FuelLevel
        {
            get => _fuelLevel;
            protected set
            {
                if (value < 0)
                    _fuelLevel = 0;
                else
                    _fuelLevel = value;
            }
        }

        protected Vehicle(string make, string model, double fuel)
        {
            Id = IdGenerator.GenerateId();
            Make = make;
            Model = model;
            FuelLevel = fuel;
        }

        public abstract void Start();

        public virtual void Stop()
        {
            Console.WriteLine($"{Make} {Model} stopped.");
        }

        public void Refuel(double amount)
        {
            FuelLevel += amount;
            Console.WriteLine($"{Make} refueled. Fuel = {FuelLevel}");
        }

        public void ConsumeFuel(double amount)
        {
            FuelLevel -= amount;
            Console.WriteLine($"{Make} consumed fuel. Fuel = {FuelLevel}");
        }
    }
}
