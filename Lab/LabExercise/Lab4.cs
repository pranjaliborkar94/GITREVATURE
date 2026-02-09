using System;
using System.Collections.Generic;

interface IRepository<T>
{
    void Add(T item);
    T Get(int id);
}

class InMemoryRepository<T> : IRepository<T>
{
    private List<T> items = new List<T>();

    public void Add(T item) => items.Add(item);

    public T Get(int id) => items[id];
}

class Lab4Repository
{
    public static void Run()
    {
        InMemoryRepository<string> repo = new InMemoryRepository<string>();
        repo.Add("Laptop");
        repo.Add("Mobile");

        Console.WriteLine(repo.Get(0));
        Console.WriteLine(repo.Get(1));
    }
}
