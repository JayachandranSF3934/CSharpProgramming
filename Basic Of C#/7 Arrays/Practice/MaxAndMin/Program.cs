using System;
namespace MaxAndMin{
class Program{
    public static void Main(string[] args)
    {
        //Get Size
        Console.Write("Enter Size of the array:");
        int size = Convert.ToInt32(Console.ReadLine());
        //Create  new array
        int[] array = new int[size];
        System.Console.WriteLine("Enter {0} elements ",size);
        for(int i=0;i<size;i++)
        {
          System.Console.Write($"Enter Element-{i} :");
          array[i] =Convert.ToInt32(Console.ReadLine()) ;
            
        }
        // min and max
        //int minimum = array[-1]  index value not start with  negative value always start with 0
        //int maximum = array[-1]
         int temp =array[0];
         int temp1 = array[0];
          

        for(int j=1;j<array.Length;j++)
        {
         if(temp < array[j])
         {
          temp = array[j];
         }
         else if(temp1 > array[j])
         {
           temp1 = array[j];
         }
         
        }
        System.Console.WriteLine($"Maximum Element is: {temp}");
        System.Console.WriteLine($"Minimum Element is: {temp1}");
    }
}
}