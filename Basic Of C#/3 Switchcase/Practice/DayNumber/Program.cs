using System;
namespace  DayNumber{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Month In Number: ");
        int month = Convert.ToInt32(Console.ReadLine());

        switch (month)
        {
            case 1:
            Console.WriteLine("This Month Have 31 Days.");
            break;

            case 2:
            Console.WriteLine("This Month Have 28 Days.  In Leap Year This Month Have 29 days. ");
            break;

            case 3:
            Console.WriteLine("This Month Have 31 Days.");
            break;

            case 4:
            Console.WriteLine("This Month Have 30 Days.");
            break;

            case 5:
            Console.WriteLine("This Month Have 31 Days.");
            break;

            case 6:
            Console.WriteLine("This Month Have 30 Days.");
            break;

            case 7:
            Console.WriteLine("This Month Have 31 Days.");
            break;

            case 8:
            Console.WriteLine("This Month Have 31 Days.");
            break;

            case 9:
            Console.WriteLine("This Month Have 30 Days.");
            break;

            case 10:
            Console.WriteLine("This Month Have 31 Days.");
            break;

            case 11:
            Console.WriteLine("This Month Have 30 Days.");
            break;

            case 12:
            Console.WriteLine("This Month Have 31 Days.");
            break;

            default:
            Console.WriteLine("Invalid");
            break;

        }
        
    }
}
}