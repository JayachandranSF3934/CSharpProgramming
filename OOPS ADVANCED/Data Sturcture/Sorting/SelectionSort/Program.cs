using System;
namespace SelectionSort{
class Program{
    public static void Main(string[] args)
    {
        // intialize array with default value
        int[] arrayDefault = new int[]{18,19,1,5,7,3,20};

       // Print unsorted array
       System.Console.WriteLine("\n\nUnsorted Array:\n");
       for (int i = 0; i < arrayDefault.Length; i++)
       {
         System.Console.Write(""+arrayDefault[i]+" ");
       }
       // calling Selection sort Method
        SortSelection(arrayDefault);

       // print  sorted array
       System.Console.WriteLine("\n\nsorted Array:\n");
       for (int i = 0; i < arrayDefault.Length; i++)
       {
         System.Console.Write(""+arrayDefault[i]+" ");
       }


       // Selection Sort Method
       int[] SortSelection(int[] array)   // Divide Array into unsorted and sorted array
       {
        int len = array.Length;    
        for(int i=0;i<len-1;i++)  //one by one move position of unsorted Subarray
        {
          int minIndex = i;  // find the minimum element in unsorted array
          for(int j=i+1;j<len;j++)
          {
            if(array[j] < array[minIndex])
            {
              minIndex = j; 
            }
          }
          // swap founded elements  with the minimumindex .
          int temp = array[minIndex];
          array[minIndex] =array[i];
          array[i] = temp;
        }return array;
       }
       



       
        
  }
}
}

