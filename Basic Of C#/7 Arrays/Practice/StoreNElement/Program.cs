using System;
namespace  StoreNElement{
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
            Console.Write($"Enter element-{i+1} :");
            number[i] =Convert.ToInt32(Console.ReadLine());
            
        }
        //Print results
        System.Console.WriteLine("Elements in array:");
        for(int j=0;j<number.Length;j++)
        {
            System.Console.Write(number[j]+" ");
        }
       
    }
}
}