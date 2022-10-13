using System;
namespace APlusB{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Value Of A");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Value Of B");
        int b = Convert.ToInt32(Console.ReadLine());

        int find = (a*a)+(2*a*b)+(b*b);
        Console.WriteLine(find);
    }
}
}