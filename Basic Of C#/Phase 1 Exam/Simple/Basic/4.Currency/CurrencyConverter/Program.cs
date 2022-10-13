using System;
namespace CurrencyConverter {
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Rate to convert in USD, EURO, CNY :");
        double rate = Convert.ToDouble(Console.ReadLine());
        
        // rate to usd 
        double usd = rate*0.0122;
        // rate to euro
        double euro = rate*0.0127;
        // rate to cny
        double cny =  rate* 0.0879;

        System.Console.WriteLine($"Indian Rupees {rate}  in USD: {usd}  , in EURO {euro}  and in CNY {cny}");
    }
}
}
