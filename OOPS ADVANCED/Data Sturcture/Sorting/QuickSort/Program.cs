using System;
namespace QuickSort{
class Program{
    public static void Main(string[] args)
    {
       
        // intialize array with default value
        int[] array = new int[]{18,19,1,5,7,3,20};
        int len = array.Length;

       // show unsorted array
       System.Console.WriteLine("\n\nUnsorted Array:\n");
       for (int i = 0; i < len; i++)
       {
         System.Console.Write(""+array[i]+" ");
       }

       // sort array using Qiuck sort method
          QuickSorting(array,0,len-1);


        // print sorted Array
       System.Console.WriteLine("\nsorted Array:\n");
       for (int i = 0; i < len;++i)
       {
         System.Console.Write(""+array[i]+" ");
       } 


       // partition the given array into  two sub array

       int Partition(int[] array, int left, int right)
       {
        int pivot = array[left];   // at first choose first element in te array as PIVOT to compare to find largest in the array

        while(true)
        {
            while(array[left] < pivot)    // the pivot is dissect the array into two subarray then will shift all smaller elements to left
            {
                left++;
            }
            while(array[right] > pivot) // the pivot dissect the other half arrray shift all larger elements to right
            {
                right--;
            }

            if(left < right)    
            {
                if(array[left] == array[right] )
                {
                    return right;    // if  two elemts are same me
                }
                int temp = array[left];   
                array[left] = array[right];
                array[right] = temp;
            }
            else
            {
                return right;
            }
        }
       }

       // Quick Sort method

       void QuickSorting(int[] arrayInput, int left, int right)
       {
        if(left < right)
        {
            int pivotFind = Partition(arrayInput,left,right);
            if(pivotFind>1)
            {
                QuickSorting(arrayInput,left,pivotFind-1);
            }
            if(pivotFind +1 < right)
            {
                QuickSorting(arrayInput,pivotFind+1,right);
            }
            
        }
       }


    }
}
}
