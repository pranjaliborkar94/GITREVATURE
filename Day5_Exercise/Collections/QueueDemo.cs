using System;
using System.Collections.Generic;

namespace Day5_Exercise.Collections
{
    public class QueueDemo
    {
        public static void Run()
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("Task1");
            q.Enqueue("Task2");

            Console.WriteLine(q.Dequeue());
        }
    }
}
