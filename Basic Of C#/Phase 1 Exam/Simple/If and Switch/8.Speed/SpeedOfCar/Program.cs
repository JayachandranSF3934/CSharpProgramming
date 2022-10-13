using System;
namespace SpeedOfCar  {
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter te speed of the car :");
        double  speed = Convert.ToDouble(Console.ReadLine());

        if(speed > 0 && speed <=10)
        {
            System.Console.WriteLine("Slow");
        }
        else if(speed > 10 && speed <=50)
        {
            System.Console.WriteLine("Average");
        }
        else if(speed > 50 && speed <=150)
        {
            System.Console.WriteLine("Fast");
        }
        else if(speed > 150&& speed <=1000)
        {
            System.Console.WriteLine("Ultra fast");
        }
        else if( speed >1000)
        {
            System.Console.WriteLine("Extrmely Fast");
        }
    }
}
}
