using System;
namespace InsertionSort{
class Program{
    public static void Main(string[] args)
    {
        // intialize array with default value
        int[] arrayDefault = new int[]{18,19,1,5,7,3,20};

       // show unsorted array
       System.Console.WriteLine("\n\nUnsorted Array:\n");
       for (int i = 0; i < arrayDefault.Length; i++)
       {
         System.Console.Write(""+arrayDefault[i]+" ");
       }
       // Call Insertion Sort
       InsertionSorting(arrayDefault);
        // print sorted array
       System.Console.WriteLine("\n\nsorted Array:\n");
       for (int i = 0; i < arrayDefault.Length; i++)
       {
         System.Console.Write(""+arrayDefault[i]+" ");
       }




       // Insertion Sort
       int[] InsertionSorting(int[] array)
       {
        int len = array.Length;

        for(int i=1;i<len;i++)  // loop to sort all element in the array
        {
            int keyValue = array[i]; // fix first index value as key and compare key value with next indexes to sort
            int j =i-1;

            while(j>=0&& array[j] > keyValue)  // while j greater than 0 and first index is greater than 0 means loop utill less than 0
            {
                array[j+1] = array[j];  // swap when it is greater
                j=j-1;

            }
            array[j+1] = keyValue; // fix next element as keyvalue tp proceed
        }
        return array;  // return all elements in array to called fuction
       }

       
        
  }
}
}

