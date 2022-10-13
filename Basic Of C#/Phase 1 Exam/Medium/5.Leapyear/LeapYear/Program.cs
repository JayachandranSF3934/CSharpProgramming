using System;
namespace LeapYear{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter The Value Of N:");
        int year=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"Leap Year From 1 to {year}");

        for(int i =1; i<=year; i++)
        {
            if(i%4 ==0 || i%400 == 0|| i%100 ==0)
            {
                if(i>128)
                {
                    System.Console.WriteLine(i);    
                }   
            }
        }
    }
}
}
