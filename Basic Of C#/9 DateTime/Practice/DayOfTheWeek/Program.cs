using System;
namespace DayOfTheWeek{
class Program{
    public static void Main(string[] args)
    {
        // create new date object with default date as yyyy month date
        DateTime date = new DateTime(2001, 12, 13);
        // Print Dey of the week
        System.Console.WriteLine($"The Day of the Week For {date:d} is {date.DayOfWeek} ");
    }
}
}
