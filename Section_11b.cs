using System;
using System.Collections.Generic;

class Section_11b
{
    public static void Run(string[] args)
    {
        int[] arr = new int[3] { 1, 2, 3 };

        var list = new List<string> { "a", "b" };
        list.Add("c");

        Console.WriteLine(arr[0]);
         Console.WriteLine(arr[1]);
        Console.WriteLine(arr[2]);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
