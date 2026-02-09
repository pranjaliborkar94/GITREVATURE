using System;
using System.Collections.Generic;

class Animal
{
    public virtual void Speak() => Console.WriteLine("Animal sound");
}

class Dog : Animal
{
    public override void Speak() => Console.WriteLine("Woof");
}

class Cat : Animal
{
    public override void Speak() => Console.WriteLine("Meow");
}

class Lab3Animal
{
    public static void Run()
    {
        List<Animal> animals = new List<Animal>
        {
            new Dog(),
            new Cat()
        };

        foreach (var a in animals)
            a.Speak();
    }
}
