using System;
namespace ByType {
class Program{


    static void Display(int number)
    {
        System.Console.WriteLine($"Number:{number}");
    }

    static void Display(string name)
    {
        System.Console.WriteLine($"Name:{name}");
    }
    public static void Main(string[] args)
    {
        Display(78);
        Display("jndad");
    }
}
}
