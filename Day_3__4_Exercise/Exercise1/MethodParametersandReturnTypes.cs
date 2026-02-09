using System;
class MethodParameterandReturnTypes
{
    public static void Run()
{
    int[] numbers = { 2, 54, 24, 5, 62, 43 };

    var result = Find(numbers);

    Console.WriteLine("From Run method:");
    Console.WriteLine("Min = " + result.min);
    Console.WriteLine("Max = " + result.max);
}


    public static (int min, int max) Find(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be empty");
        }

        int min = numbers[0];
        int max = numbers[0];

        foreach (var n in numbers)
        {
            if (n > max) max = n;
            if (n < min) min = n;
        }

        return (min, max);
    }
         
}
