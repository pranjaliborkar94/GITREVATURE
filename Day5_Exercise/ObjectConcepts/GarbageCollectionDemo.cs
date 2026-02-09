using System;

namespace Day5_Exercise.ObjectConcepts
{
    class Demo
    {
        ~Demo()
        {
            Console.WriteLine("Garbage collected");
        }
    }

    public class GarbageCollectionDemo
    {
        public static void Run()
        {
            Demo d = new Demo();
            d = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
