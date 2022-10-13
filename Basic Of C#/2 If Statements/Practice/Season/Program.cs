using System;
namespace  Season{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Month to know season");
        string month = Console.ReadLine().ToLower();

        if (month == "december" ||month == " january" ||month == "february" )
        {
            Console.WriteLine("winter");
        }
        else if
        ((month == "march" ||month == " april" ||month == "may"))
        {
            Console.WriteLine("spring");
        }
        else if ((month == "june" ||month == " july" ||month == "augest"))
        {
            Console.WriteLine("Summer");
        }
        else if ((month == "september" ||month == " november" ||month == "october"))
        {
            Console.WriteLine("Rainfall");
        }
        else
        {
            Console.WriteLine("Invaild");
        }
    }
}
}