using System;
namespace InsertionSort{
class Program{
    public static void Main(string[] args)
    {
        // intialize array with default value
        int[] arrayDefault = new int[]{18,19,1,5,7,3,20};
        int len = arrayDefault.Length;

       // show unsorted array
       System.Console.WriteLine("\n\nUnsorted Array:\n");
       for (int i = 0; i < len; i++)
       {
         System.Console.Write(arrayDefault[i]+" ");
       }
       
       // Calling MERGE  and SORT Method
       SortMethod(arrayDefault,0,len-1);
       // Show Sorted Array
       System.Console.WriteLine("\n\nsorted Array:\n");
       for (int i = 0; i < len; i++)
       {
         System.Console.Write(arrayDefault[i]+" ");
       }
       

       //--------------------------------------------------------------------------------------------------------------------
        // sort method
       void SortMethod(int[] integerTwo, int left, int right)
       {
        int mid;
        if(right > left)  // if right vaule is greater than left proceed further
        {
            mid = (right + left)/2;   // divide unsorted array by find the mid value and divide into two pieces.

            SortMethod(integerTwo,left,mid);  // Repeat same process for the left side unsorrted array
            SortMethod(integerTwo,(mid+1),right); // Repeat same process for the right side unsortted array
            Merge(integerTwo,left,(mid+1),right);  // Merge all the sorted subarray into single array
        }

       // Merge method
       void Merge(int[] integer,int left,int mid,int right)     // merge array must contains the array name, left , right and mid
       {
        int[] temp = new int[50];  // intialize  new subarray temp 
        int leftSide =(mid -1);  // leftside subarray = mid-1
        int tempPosition = left;  // temporay position
        int elements = (right - left +1);  // assign elements = right-left +1 --> 6+0-1 = 5

        while((left <= leftSide) && (mid <= right))
        {
            if(integer[left] <= integer[mid])
            {
                temp[tempPosition++] = integer[left++];
            }
            else
            {
                temp[tempPosition++] = integer[mid++];
            }
        }
        while(left <= leftSide)
        {
            temp[tempPosition++] = integer[left++];
        }
        while(mid <= right)
        {
            temp[tempPosition++] =integer[mid++];
        }

        for (int i = 0; i < elements; i++)
        {
            integer[right] = temp[right];
            right--;
        }
       }      
       }
      




     


       
        
  }
}
}

