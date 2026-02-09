using System;
using System.Collections.Generic;

namespace Day5_Exercise.Collections
{
    public class StackDemo
    {
        public static void Run()
        {
            Stack<int> s = new Stack<int>();
            s.Push(10);
            s.Push(20);

            Console.WriteLine(s.Pop());
        }
    }
}
