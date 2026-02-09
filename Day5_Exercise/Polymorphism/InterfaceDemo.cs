using System;

namespace Day5_Exercise.Polymorphism
{
    interface IWorker
    {
        void Work();
    }

    class Developer : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Developer working");
        }
    }

    public class InterfaceDemo
    {
        public static void Run()
        {
            IWorker w = new Developer();
            w.Work();
        }
    }
}
