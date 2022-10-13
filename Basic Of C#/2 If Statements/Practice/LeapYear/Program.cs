using System;
namespace LeapYear {
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Year:");
        int year = int.Parse(Console.ReadLine());
        if (year % 400 == 0)
        {
            Console.WriteLine($"{year} is a leap year");
        }
        else if (year % 100 == 0)
        {
            Console.WriteLine($"{year} is a leap year");
        }
        else if (year % 4 == 0)
        {
            Console.WriteLine($"{year} is a leap year");
        }
        else 
        {
            Console.WriteLine($"{year} is  Not a leap year");
        }
       ;
    }
}
}