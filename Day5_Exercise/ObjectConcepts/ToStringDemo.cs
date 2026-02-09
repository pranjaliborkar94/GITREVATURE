using System;

namespace Day5_Exercise.ObjectConcepts
{
    class Person
    {
        public string Name;

        public override string ToString()
        {
            return "Name: " + Name;
        }
    }

    public class ToStringDemo
    {
        public static void Run()
        {
            Person p = new Person();
            p.Name = "Pranjali";
            Console.WriteLine(p);
        }
    }
}
