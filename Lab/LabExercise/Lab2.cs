using System;

class BankAccount
{
    public int Balance { get; private set; }

    public void Deposit(int amount)
    {
        if (amount > 0)
            Balance += amount;
    }

    public void Withdraw(int amount)
    {
        if (amount > 0)
            Balance -= amount;
    }

    public bool IsOverdrawn => Balance < 0;
}

class Lab2Bank
{
    public static void Run()
    {
        BankAccount acc = new BankAccount();
        acc.Deposit(1000);
        acc.Withdraw(1500);

        Console.WriteLine("Balance: " + acc.Balance);
        Console.WriteLine("Is Overdrawn: " + acc.IsOverdrawn);
    }
}
