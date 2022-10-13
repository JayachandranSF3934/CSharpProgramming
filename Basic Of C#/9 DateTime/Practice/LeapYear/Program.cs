using System;
namespace LeapYear{
class Program{
    public static void Main(string[] args)
    {
        for(int i = 1995; i<=2016;i++)
        {
            if(DateTime.IsLeapYear(i))
            {
                System.Console.WriteLine($"{i} is a leap year");
                DateTime leap = new DateTime(i, 2, 29);
                DateTime nextYear = leap.AddYears(1);
                System.Console.WriteLine($"one Year From {leap.ToString("d")} is {nextYear.ToString("d")}");
            } 
        }
    }
}
}
