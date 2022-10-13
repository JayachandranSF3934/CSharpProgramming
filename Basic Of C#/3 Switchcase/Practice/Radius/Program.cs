using System;
namespace Radius{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input Radius To Calculate :");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("1.Area. \n2.Perimeter. \n3.Diameter");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
            Console.WriteLine($"The Area is: {radius*radius*3.14}");
            break;

            case 2:
            Console.WriteLine($"The Perimeter is: {2*radius*3.14}");
            break;
            
            case 3:
            Console.WriteLine($"The Area is: {radius*2}");
            break;
        }
    }
}
}