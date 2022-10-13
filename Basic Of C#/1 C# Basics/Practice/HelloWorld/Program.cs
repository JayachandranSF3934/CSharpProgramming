using System;
namespace helloWorld;
class Program
{    //1.		Write a C# Sharp program to print Hello and your name in a separate line. Using both Place holder, Concatenation and $ 

public static void Main(string[] args)
{
    Console.WriteLine("Enter your Name");
     string name = Console.ReadLine();
    Console.WriteLine("Hello: "+name);
    Console.WriteLine("Hello: {0}",name);
    Console.WriteLine($"Hello: {name}");
}
}