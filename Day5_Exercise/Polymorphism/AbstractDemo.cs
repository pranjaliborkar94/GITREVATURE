using System;

namespace Day5_Exercise.Polymorphism
{
    abstract class Shape
    {
        public abstract void Draw();
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }

    public class AbstractDemo
    {
        public static void Run()
        {
            Shape s = new Circle();
            s.Draw();
        }
    }
}
