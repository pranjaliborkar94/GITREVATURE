using System;
using System.Collections.Generic;

class Section_5
{
    public static void Run()
    {
        var x = 10;                 // compiler treats it as int
        var list = new List<string>(); // compiler treats it as List<string>

        list.Add("Apple");
        list.Add("Banana");

        Console.WriteLine(x);
        Console.WriteLine(list.Count);
    }
}
