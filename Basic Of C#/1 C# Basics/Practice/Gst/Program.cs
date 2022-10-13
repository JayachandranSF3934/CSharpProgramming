using System;
namespace Gst {
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Product price :");
        int price = Convert.ToInt32(Console.ReadLine());
//Calculating GST
        double total = price + price*0.18;

        Console.WriteLine("Total Price With GST: "+total);
        
    }
}
}