using System;
namespace AreaAndPerimeter{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Radius to find area and perimeter of a circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        //area
         double area = 3.14*radius*radius;
         // perimeter
         double perimeter = 2*3.14*radius;

         System.Console.WriteLine($"Area = {area} \n Perimeter = {perimeter}");
    }
}
}
