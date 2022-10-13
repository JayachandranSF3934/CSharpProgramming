using System;
namespace Multiplication{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number(Table to be calculated): ");
        int table =Convert.ToInt32( Console.ReadLine());
        int number =0;
        Console.WriteLine($"Table for {table} is :");
        for(int i=1;i<=10;i++)
        {
            number = i*table;
            Console.WriteLine($"{table} X {i} = {number}");
        }
    }
}
}