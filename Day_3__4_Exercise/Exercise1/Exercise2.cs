using System;

public class Exercise2
{
    // Run method (application starts here after Main)
    public static void Run()
{
    Exercise2 calc = new Exercise2();

    Console.WriteLine("\nMethod Overloading Example:");

    Console.WriteLine("Int Add: " + calc.Add(10, 20));
    Console.WriteLine("Double Add: " + calc.Add(10.5, 20.3));
    Console.WriteLine("Decimal Add: " + calc.Add(100.25m, 200.75m));
}


    // int version
    public int Add(int a, int b)
    {
        return a + b;
    }

    // double overload
    public double Add(double a, double b)
    {
        return a + b;
    }

    // decimal overload
    public decimal Add(decimal a, decimal b)
    {
        return a + b;
    }
}
