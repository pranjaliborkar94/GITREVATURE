using System;
using Day5_Exercise.Polymorphism;
using Day5_Exercise.ObjectConcepts;
using Day5_Exercise.Collections;

namespace Day5_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- POLYMORPHISM ----");
            MethodOverloading.Run();
            MethodOverriding.Run();
            AbstractDemo.Run();
            InterfaceDemo.Run();

            Console.WriteLine("\n---- OBJECT CONCEPTS ----");
            ToStringDemo.Run();
            EqualsDemo.Run();
            GarbageCollectionDemo.Run();

            Console.WriteLine("\n---- COLLECTIONS ----");
            ListDemo.Run();
            DictionaryDemo.Run();
            QueueDemo.Run();
            StackDemo.Run();
        }
    }
}
