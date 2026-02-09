using System;

namespace Day5_Exercise.Polymorphism
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal sound");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }

    public class MethodOverriding
    {
        public static void Run()
        {
            Animal a = new Dog();
            a.Speak();
        }
    }
}
