using System;
namespace InchToCm {
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter inches:");
        double inch = Convert.ToDouble(Console.ReadLine());

        double centimeter =  inch*2.54;
        System.Console.WriteLine($"{inch} inch = {centimeter}cm");
    }
}
}
