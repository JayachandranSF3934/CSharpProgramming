using System;
namespace Distance{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Speed In Km/hr:");
        int speed = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Time  In Sec:");
        int time = Convert.ToInt32(Console.ReadLine());

        // Distance
        int distance = speed*time*5/18;
        Console.WriteLine("Distance travel by the vechicle :"+distance+" Meters");
    }
}
}