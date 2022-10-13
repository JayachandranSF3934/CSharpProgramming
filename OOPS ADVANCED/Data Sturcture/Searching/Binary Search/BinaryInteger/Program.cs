using System;
namespace BinaryInteger {
class Program{
    public static void Main(string[] args)
    {
        int[] integerArray = new int[]{2,3,4,8,96,56,33};
        Array.Sort(integerArray);
        int searchElement = 4;
        // Calling Binary Search
        
        if (BinarySearchInteger(integerArray,searchElement) !=0)
        {
             System.Console.WriteLine($"Element Found in the Position ");
             System.Console.WriteLine(BinarySearchInteger(integerArray,searchElement));
            
        }
        else
        {
            System.Console.WriteLine("Element Not Found in the Array");
        }


        int  BinarySearchInteger(int[] array, int number)
        {
            int start = 0;
            int end = array.Length -1;
    
            while(start <= end)
            {
              int mid = (start+end)/2;
                if(number == array[mid])
                {
                    return mid+1; 
                }
                else if(number < array[mid])
                {
                    end = mid -1;
                }
                else if(number > array[mid])
                {
                    start = mid+1;
                }  
            }
            return 0;
        }
    }
}
}


