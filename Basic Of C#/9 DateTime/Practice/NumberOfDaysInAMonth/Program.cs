using System;
using System.Globalization;
namespace NumberOfDaysInAMonth {
class Program{
    public static void Main(string[] args)
    {
        int month, year;
        System.Console.WriteLine("Enter the Month Of the year in number like 1,2,3,4,5...");
        month = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter The Year ");
        year = Convert.ToInt32(Console.ReadLine());
        DateTimeFormatInfo dinfo = new DateTimeFormatInfo();  // using globalization library you can get dateTimeFormatinfo method.
        string monthNumber = dinfo.GetMonthName(month);
        int numOfDays = DateTime.DaysInMonth(year,month);
        System.Console.WriteLine($"The Number of Days in the {monthNumber}month is {numOfDays}Days. "); 
    }
}
}
