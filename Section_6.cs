using System;

class Section_6
{
    public static void Run()
    {
        int? n = null;
        int value = n ?? -1; // null-coalescing operator

        string? s = null;
        int? length = s?.Length; // null-conditional (safe access)

        Console.WriteLine(value);
        Console.WriteLine(length);
    }
}
