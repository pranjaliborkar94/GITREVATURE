using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}

class Lab1Person
{
    public static void Run()
    {
        Person p = new Person("Pranjali", 22);
        Console.WriteLine(p);
    }
}
