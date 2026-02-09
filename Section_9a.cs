using System;

class Section_9a
{
    public static void Run()
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
