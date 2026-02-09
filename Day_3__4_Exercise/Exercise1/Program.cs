class Program
{
    public static void Main()
    {
        Console.WriteLine("Program Started...\n");

        int[] numbers = { 2, 54, 24, 5, 62, 43 };

        var result = MethodParameterandReturnTypes.Find(numbers);

        Console.WriteLine("From Main method:");
        Console.WriteLine("Min = " + result.min);
        Console.WriteLine("Max = " + result.max);

        MethodParameterandReturnTypes.Run();
        Exercise2.Run();
        NamedAndPositionalDemo.Run(101, name: "Pranjali", department: "IT", salary: 25000);
        Exercise4.Run();
        Exercise5.Run();
        
    }
}
