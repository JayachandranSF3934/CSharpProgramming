using System;
namespace AddMatrix {
class Program{
    public static void Main(string[] args)
    {
        //get input
        Console.WriteLine("Enter number of Elements in the array");
        int size = Convert.ToInt32( Console.ReadLine());
        //enter values 
        int[] number = new int[size];
        for(int i=0;i<size;i++)
        {
            Console.Write($"Enter element-{i} :");
            number[i] =Convert.ToInt32(Console.ReadLine());
            
        }
    }
}
}