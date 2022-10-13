using System;
namespace CelciusToFarenheit{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Celcius °C To Find Farenheit:");
        double celcius = Convert.ToDouble(Console.ReadLine());
        // celcius to farenheit
        double farenheit = celcius *(9/5)+32;
        System.Console.WriteLine($"{farenheit} Farenheit ");

    }
}
}
