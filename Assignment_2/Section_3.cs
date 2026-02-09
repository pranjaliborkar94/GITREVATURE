//Summary: Fixed-size and value types; numeric precision and when to use decimal (money).
using System;
class Section_3{
    public static void Run(){
int a = 42;
long big = 3_000_000_000L;
float f = 3.14f;
double d = 2.71828;
decimal money = 19.99m;
bool ok = true;
char letter = 'A';

Console.WriteLine(a);
Console.WriteLine(big);
Console.WriteLine(f);
Console.WriteLine(money);
Console.WriteLine(ok);
Console.WriteLine(letter);
Console.WriteLine(d);

    }}