using System;
namespace DayName {
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Number to Know the Day:");
        int num= Convert.ToInt32(Console.ReadLine());

        switch (num)
        {
            case 1:
            Console.WriteLine("Monday");
            break;

            case 2:
            Console.WriteLine("Tuesday");
            break;

            case 3:
            Console.WriteLine("Wednesday");
            break;

            case 4:
            Console.WriteLine("Thursday");
            break;

            case 5:
            Console.WriteLine("Firday");
            break;

            case 6:
            Console.WriteLine("Saturday");
            break;

            case 7:
            Console.WriteLine("Sunday");
            break;

            default:
            Console.WriteLine("Invalid");
            break;

        }
    }
}
}