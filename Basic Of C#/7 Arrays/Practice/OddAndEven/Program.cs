using System;
namespace  OddAndEven{
class Program{
    public static void Main(string[] args)
    {
        //get input
        Console.WriteLine("Enter number of Elements in the array");
        int size = Convert.ToInt32( Console.ReadLine());
        //enter values 
        int[] array1 = new int[size];
        for(int i=0;i<size;i++)
        {
            Console.Write($"Enter element-{i} :");
            array1[i] =Convert.ToInt32(Console.ReadLine());   
        }
        // Odd or Even 
         int[] array3 = new int[size];
         int[] array2 = new int[size];
         // to find the array1 elements are odd or even
         for(int k =0;k<size;k++)
         {
            if(array1[k] % 2 ==0)
            {
            // if even store this element in array2
                array2[k] = array1[k] ;
                
            }
            else{
                // else estore this element in array3 as odd
                array3[k] =  array1[k];
            }
         }

         for(int a=0;a<array2.Length;a++)
         {
            Console.WriteLine($"The Even Number in the array are : \n{array2[a]}");
         }

         for(int b=0;b<array3.Length;b++)
         {
            Console.WriteLine($"The Odd Number in the array are :\n{array3[b]}");
         }
    }
}
}