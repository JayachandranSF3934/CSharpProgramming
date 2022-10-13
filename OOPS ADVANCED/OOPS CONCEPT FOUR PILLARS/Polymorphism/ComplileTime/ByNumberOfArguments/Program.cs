using System;
namespace ByNumberOfArguments{
class Program{
    // method with parameter
    static void Display(int number)
    {
        System.Console.WriteLine($"Arguments:{number}");
    }
    // Method with two parameter

    static void Display(int number,int numberTwo)
    {
        System.Console.WriteLine($"ArgumentOne:{number}  ArgumentTwo:{numberTwo}");
    }
    






    public static void Main(string[] args)
    {
        Console.WriteLine("Dispaly method using Complie Time Polymorphism -> Method Overloading");  // By Arugemts
        Display(19901);
        Display(23232, 43223);
        
        Console.ReadLine();
    }
}
}
