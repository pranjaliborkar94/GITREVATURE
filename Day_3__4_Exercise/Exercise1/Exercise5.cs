public class Exercise5
{
    public static void Run()
    {
        Exercise5 calc = new Exercise5();

        Console.WriteLine("Int Add: " + calc.Add(10, 20));
        Console.WriteLine("Double Add: " + calc.Add(10.5, 20.3));
        Console.WriteLine("Decimal Add: " + calc.Add(100.25m, 200.75m));
    }

    // Expression-bodied methods
    public int Add(int a, int b) => a + b;

    public double Add(double a, double b) => a + b;

    public decimal Add(decimal a, decimal b) => a + b;
}