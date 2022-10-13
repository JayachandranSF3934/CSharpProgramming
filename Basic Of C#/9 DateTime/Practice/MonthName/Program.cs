using System;
namespace MonthName{
class Program{
    public static void Main(string[] args)
    {
        DateTime today = DateTime.Today;
        Console.WriteLine($"The Date of Today is {today.ToString("dd/MM/yyyy")}\n");
        System.Console.WriteLine("The Next Twelve Month from today is :\n ");
        for(int i= 0;i<12;i++)
        {
            System.Console.WriteLine($"{today.ToString("MMMM")}");
            today = today.AddMonths(1);

        }
    }
}
}
