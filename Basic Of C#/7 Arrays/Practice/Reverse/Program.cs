using System;
namespace Reverse {
class Program{
    public static void Main(string[] args)
    {   // get size
        Console.WriteLine("Enter Number of Elements to store in array:");
        int size = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"Enter {size} Number of Elements:");
        //create  new array
        int[] number= new int[size];
        // get array elements
        for(int i=0;i<size;i++)
        {
            System.Console.Write($"Enter Element-{i}:");
            number[i]=Convert.ToInt32(Console.ReadLine());
        }  
        //Print array
        System.Console.WriteLine("The Value stored into  array are:");
        for(int j=0;j<number.Length;j++)
        {
            System.Console.Write(number[j]+" ");
        }   
        // Print array in reverse
        System.Console.WriteLine("\nThe Value stored into  array in Reverse are:");  
        for(int k =number.Length-1;k>=0;k--)
        {
            System.Console.Write(number[k]+" ");
        }
    }
}
}