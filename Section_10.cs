using System;

class Section_10
{
    public static void Run(string[] args)
    {
        int a = 10;
        int b = 5;
        int sum = a + b;

        int numerator = 7;
        int denominator = 2;
        double ratio = (double)numerator / denominator;

        int r = 7 % 3; // remainder

        Console.WriteLine(sum);
        Console.WriteLine(ratio);
        Console.WriteLine(r);
    }
}
