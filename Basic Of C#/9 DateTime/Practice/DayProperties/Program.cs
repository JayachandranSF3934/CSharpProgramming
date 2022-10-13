using System;
namespace DayProperties{
class Program{
    public static void Main(string[] args)
    {
        // GET INPUT FROM USER
        Console.Write("Enter DateTime In the Format  yyyy/MM/dd  hh:mm:ss: msAM or PM:");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());
        System.Console.WriteLine($"\n\nYear={inputDate.Year}\nMonth={inputDate.Month}\nDay={inputDate.Day}\nHours={inputDate.Hour}\nMinutes={inputDate.Minute}\nSecomd={inputDate.Second}\nMilliseconds={inputDate.Millisecond}");
    }
}
}
