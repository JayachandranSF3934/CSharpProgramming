using System;
namespace volumeOfCylinder;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter The Radius Of the Cylinder:");
        int radius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter The Height Of the Cylinder:");
        int height = Convert.ToInt32(Console.ReadLine());

        // Volume of Cylinder
        double volume = 3.14*(radius)*(radius)*(height);
        Console.WriteLine("Volume:"+ volume);    }
}

Console.ReadLine();
