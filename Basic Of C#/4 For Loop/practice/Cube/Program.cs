using System;
namespace Cube {
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Number of Terms");
        int terms =Convert.ToInt32(Console.ReadLine());
        int cube =0;
        for(int i=1;i<=terms;i++)
        {
            cube = i*i*i;
            System.Console.WriteLine($"Number is:{i} and cube of the {i} is:{cube} ");
        }
    }
}
}