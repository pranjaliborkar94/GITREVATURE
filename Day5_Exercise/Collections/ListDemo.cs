using System;
using System.Collections.Generic;

namespace Day5_Exercise.Collections
{
    public class ListDemo
    {
        public static void Run()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            list.Add(4);

            foreach (var i in list)
                Console.WriteLine(i);
        }
    }
}
