using System;
namespace OperatorOverloading {
class Program{
    public static void Main(string[] args)
    {
        Box box1 = new Box(23,22,32);
        Box box2 = new Box(22,1,2);
        Box box3 = new Box();
        Box box4 = new Box();

        double volume = box1.CalculateVolume();
        System.Console.WriteLine(volume);

        double volume2 = box2.CalculateVolume();
        System.Console.WriteLine(volume2);

        box3 = box1+box2;
        double volume3 = box3.CalculateVolume();
        System.Console.WriteLine(volume3);

        




        





        
    }
}
}
