using System;
namespace NumberOfDaysOfTheYear{
class Program{
    public static void Main(string[] args)
    {
        DateTime startDate = new DateTime (2000, 12, 31);
        for (int i=0; i<=8;i++)
        {
            DateTime date = startDate.AddYears(i);
            System.Console.WriteLine($"{date:d}:  Day {date.DayOfYear} of {date.Year} ");
        }
    }
}
}
