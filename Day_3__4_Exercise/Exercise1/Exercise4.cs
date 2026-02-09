using System;

public static class Exercise4
{
    // Extension method
    public static int? ToIntOrNull(this string value)
    {
        if (int.TryParse(value, out int result))
        {
            return result;
        }

        return null;
    }

    // Runner method to call from Program.cs
    public static void Run()
    {
        string s1 = "123";
        string s2 = "abc";
        string s3 = null;

        int? num1 = s1.ToIntOrNull();
        int? num2 = s2.ToIntOrNull();
        int? num3 = s3.ToIntOrNull();

        Console.WriteLine("Exercise 4 Output:");
        Console.WriteLine("s1 → " + num1);
        Console.WriteLine("s2 → " + (num2.HasValue ? num2.Value.ToString() : "null"));
        Console.WriteLine("s3 → " + (num3.HasValue ? num3.Value.ToString() : "null"));
    }
}
