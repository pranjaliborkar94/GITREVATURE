using System;

class Person
{
    public int Age { get; set; }

    // initialize to avoid CS8618 warning
    public string Name { get; set; } = "";
}

class Section_8a
{
    public static void Run()
    {
        object o = 5;

        if (o is int i)
            Console.WriteLine(i + 1);

        // create person object
        var person = new Person { Age = 20, Name = "Rahul" };

        // property pattern
        if (person is { Age: >= 18, Name: var n })
            Console.WriteLine(n);
    }
}

