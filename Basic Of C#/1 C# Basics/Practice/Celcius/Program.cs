using System;
namespace Celcius;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the amount of Celcius: ");
        int celcius =Convert.ToInt32(Console.ReadLine());

      // Kelvin
      int kelvin = celcius + 273;
      Console.WriteLine("Kelvin = " +kelvin);

     // fahrenheit
     int farenheit = (celcius*9/5) +32;
     Console.WriteLine("Farenheit ="+farenheit);
      
    }
}
