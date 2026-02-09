using System;
class Section_4a{

public static void Run(){
string s = "Hello" + " World";
string template = $"User: {Environment.UserName}, Date: {DateTime.Today:d}";

Console.WriteLine(s);
Console.WriteLine(template);
}
}