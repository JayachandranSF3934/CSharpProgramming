using System;
namespace LengthToMetre {
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Value Length In Metre: ");
        double metre = Convert.ToDouble(Console.ReadLine());

        // Centimeter
        double cm = metre *100;
        Console.WriteLine("cm: "+cm);
        //Mellimeter
         double mm = cm *10;
        Console.WriteLine("mm: "+mm);
        //inch
        double inch = 39.3*metre;
        Console.WriteLine("inch: "+inch);
        //foot
        double foot = 12*metre;
        Console.WriteLine( "foot: "+foot);
        //mile
         double mile = 0.0006213715277778 * metre;
        Console.WriteLine("mile :"+mile);
        

    }
}
}