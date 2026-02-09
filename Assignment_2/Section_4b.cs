using System;
using System.Text;

class Section_4b
{
    public static void Run(string[] args)
    {
        var sb = new StringBuilder();
        sb.Append("Line1").AppendLine();
        sb.AppendFormat("{0} items", 5);

        string result = sb.ToString();

        Console.WriteLine(result);
    }
}

