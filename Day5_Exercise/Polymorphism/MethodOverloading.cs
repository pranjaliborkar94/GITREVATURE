using System;

namespace Day5_Exercise.Polymorphism
{
    class Calculator
    {
        public int Add(int a, int b) => a + b;
        public double Add(double a, double b) => a + b;
    }

    public class MethodOverloading
    {
        public static void Run()
        {
            Calculator c = new Calculator();
            Console.WriteLine(c.Add(10, 20));
            Console.WriteLine(c.Add(10.5, 5.5));
        }
    }
}
