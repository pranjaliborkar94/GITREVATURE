using System;

class Section_7b
{
    public static void Run()
    {
        int x = 5;

        var result = x switch
        {
            0 => "zero",
            > 0 => "positive",
            < 0 => "negative"
        };

        Console.WriteLine(result);
    }
}
