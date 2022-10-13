using System;
namespace BubbleSort{
class Program{
    public static void Main(string[] args)
    {
        // intialize array with default value
        int[] array = new int[]{18,19,1,5,7,3,20};

       // show unsorted array
       System.Console.WriteLine("\n\nUnsorted Array:");
       for (int i = 0; i < array.Length; i++)
       {
         System.Console.Write(""+array[i]+" ");
       }

       // sort array using bubble sort method
       BubleSorting(array);

        // print sorted Array
       System.Console.WriteLine("\n\nsorted Array:");
       for (int i = 0; i < array.Length;++i)
       {
         System.Console.Write(""+array[i]+" ");
       }

       // buuble sort
       int[] BubleSorting(int[] arr)
       {
        int len = arr.Length-1;
        for(int i=0;i<len;i++)
        {
            for(int j=0;j<len-i;j++)     // Issues   Len-i   != len-i-1
            {
                if(arr[j] > arr[j+1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }return arr;
       }

    }
}
}
