using System;
using System.Collections.Generic;

namespace Day5_Exercise.Collections
{
    public class DictionaryDemo
    {
        public static void Run()
        {
            Dictionary<int, string> data = new Dictionary<int, string>();
            data[1] = "A";
            data[2] = "B";

            foreach (var item in data)
                Console.WriteLine(item.Key + " " + item.Value);
        }
    }
}
