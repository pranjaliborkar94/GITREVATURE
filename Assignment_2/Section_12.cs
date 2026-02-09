using System;
using System.Collections.Generic;

class Section_12
{
    public static void Run(string[] args)
    {
        int[] arr = { 1, 2, 3 };
        var list = new List<string> { "a", "b", "c" };
        //int i=0;

        // for loop
        for (int i = 0; i < arr.Length; i++)
            Console.WriteLine(arr[i]);

        // foreach loop
        foreach (var item in list)
            Console.WriteLine(item);

        // while loop
        int j = 0;
        while (j++ < 5)
        {
            
            Console.WriteLine("While loop running: " + j);

        }
    }
}
