using System;

class Section_9b
{
    public static void Run(string[] args)
    {
        int x = 50;
        bool isReady = false;
        bool hasData = true;

        if (x > 0 && x < 100)
        {
            Console.WriteLine("x is in range");
        }

        if (!(isReady || hasData))
            return;

        Console.WriteLine("Program continues...");
    }
}
