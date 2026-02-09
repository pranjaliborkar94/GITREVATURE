using System;

class Per
{
    // Inline comment
    /* block comment */

    /// <summary>Gets the name.</summary>
    public string Name { get; }

    public  Per(string name)
    {
        Name = name;
    }
}

class Section_13
{
    public static void Run(string[] args)
    {
        var per = new Per("Rahul");
        Console.WriteLine(per.Name);
    }
}
