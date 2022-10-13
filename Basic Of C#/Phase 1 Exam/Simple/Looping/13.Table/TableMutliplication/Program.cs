using System;
namespace TableMultiplication {
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Number (Table of the number to be calculated): ");
        int table = Convert.ToInt32(Console.ReadLine());
        int number;
        System.Console.WriteLine($"The Table of {table} is ");

        for(int i=1;i<=20;i++)
        {
            number = i*table;
            Console.WriteLine($"{table} X {i} = {number}");
        }
        
    }
}
}
