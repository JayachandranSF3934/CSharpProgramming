using System;
namespace DayOfWeekFromCurrentDay {
class Program{
    public static void Main(string[] args)
    {
        DateTime date = DateTime.Now;
        DateTime after = date.AddDays(40);
        System.Console.WriteLine($"\nCurrent Date and Time :{date}");
        System.Console.WriteLine($"\nAfter 40 Days The Date is : {after} and the Day of the week is {after:dddd}\n");
    }
}
}
