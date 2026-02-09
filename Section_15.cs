using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

record Student(string Name, int Age);

class Section_15
{
    public static void Run(string[] args)
    {
        // Sample CSV lines
        string[] csvLines =
        {
            "Rahul,22",
            "Anita,17",
            "John,30",
            "Priya,15"
        };

        // Parse CSV into List<Student>
        List<Student> students = csvLines
            .Select(line =>
            {
                var parts = line.Split(',');
                return new Student(parts[0], int.Parse(parts[1]));
            })
            .ToList();

        // Filter adults (Age >= 18) using pattern matching + LINQ
        var adults = students
            .Where(s => s is { Age: >= 18 })
            .ToList();

        Console.WriteLine("Adults:");
        foreach (var student in adults)
        {
            Console.WriteLine($"{student.Name} - {student.Age}");
        }

        Console.WriteLine();

        // Compare string concatenation vs StringBuilder
        int iterations = 10000;

        // Using +
        Stopwatch sw1 = Stopwatch.StartNew();
        string concat = "";
        for (int i = 0; i < iterations; i++)
        {
            concat += "Hello";
        }
        sw1.Stop();
        
        // Using StringBuilder
        Stopwatch sw2 = Stopwatch.StartNew();
        var sb = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            sb.Append("Hello");
        }
        string result = sb.ToString();
        sw2.Stop();

        Console.WriteLine($"Concatenation time: {sw1.ElapsedMilliseconds} ms");
        Console.WriteLine($"StringBuilder time: {sw2.ElapsedMilliseconds} ms");
    }
}
