using System;

class Section_8b
{
    public static void Run()
    {
        Console.WriteLine(Describe(null));
        Console.WriteLine(Describe(10));
        Console.WriteLine(Describe("Hello"));
        Console.WriteLine(Describe(3.14));
    }

    // switch with type patterns
    static string Describe(object? obj) => obj switch
    {
        null => "none",
        int i => $"int {i}",
        string s => $"str({s})",
        _ => "other"
    };
}
