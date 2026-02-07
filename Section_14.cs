using System;
using System.Text; // brings StringBuilder into scope

namespace Assignment
{
    public class Worker
    {
    }

    class Section_14
    {
        public static void Run(string[] args)
        {
            var sb = new StringBuilder();
            sb.Append("Hello Worker");

            Console.WriteLine(sb.ToString());
        }
    }
}
