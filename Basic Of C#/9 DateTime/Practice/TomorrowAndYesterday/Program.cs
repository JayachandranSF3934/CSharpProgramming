using System;
namespace TomorrowAndYesterday{
class Program{
    static void Main(string[] args)
    {
        string  today = DateTime.Today.ToString("dd/MM/yyyy");
        System.Console.WriteLine($"Today is {today} \n\n\n");
        DateTime yesterday = Yesterday();
        DateTime tomorrow = Tomorrow();

        Console.WriteLine($"Yesterday Was ~~ {yesterday.ToString("dd/MM/yyyy")}\n");
        Console.WriteLine($"Tomorrow is ~~{tomorrow.ToString("dd/MM/yyyy")}\n");
    }
    static DateTime Yesterday()
    {
        return DateTime.Today.AddDays(-1);
    }
    static DateTime Tomorrow()
    {
        return DateTime.Today.AddDays(1);
    }
}
}
