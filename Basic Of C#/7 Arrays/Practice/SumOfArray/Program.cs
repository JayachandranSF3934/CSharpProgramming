using System;
namespace SumOfArray{
class Program{
    public static void Main(string[] args)
    {   
        //Get size
        Console.WriteLine("Enter Size of the Array:");
        int size = Convert.ToInt32(Console.ReadLine());

        // create array
        int[] array = new int[size];
        for(int i=0;i<size;i++)
        {
            System.Console.Write($"Enter Elements-{i} :");
            array[i]=Convert.ToInt32(Console.ReadLine());
        }

        //sum of array

        System.Console.Write("Sum of All The Elements Stored in the array:  ");
        int sum=0;
        for(int j=0;j<array.Length;j++)
        {
            sum = sum +array[j];   
        }
        System.Console.WriteLine(sum);


       
    }
}
}