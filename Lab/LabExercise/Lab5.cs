using System;

abstract class Shape
{
    public abstract double Area();
}

class Circle : Shape
{
    public double Radius;
    public Circle(double r) { Radius = r; }

    public override double Area() => Math.PI * Radius * Radius;
}

class Rectangle : Shape
{
    public double Width, Height;
    public Rectangle(double w, double h)
    {
        Width = w;
        Height = h;
    }

    public override double Area() => Width * Height;
}

class Lab5Shapes
{
    public static void Run()
    {
        Shape c = new Circle(5);
        Shape r = new Rectangle(4, 6);

        Console.WriteLine("Circle Area: " + c.Area());
        Console.WriteLine("Rectangle Area: " + r.Area());
    }
}
