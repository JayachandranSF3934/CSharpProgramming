using System;
namespace BinaryCharater{
class Program{
    public static void Main(string[] args)
    {
        char[] charArray = new char[]{'a','c','g','z','r','e','h'};
        Array.Sort(charArray);
        char searchChar = 'h';
        // Calling Binary Search
        
        if (BinarySearchCharacter(charArray,searchChar) !=0)
        {
             System.Console.Write($"Character Found in the  Array and the Position is   ");
             System.Console.Write(BinarySearchCharacter(charArray,searchChar));
            
        }
        else
        {
            System.Console.WriteLine("Character Not Found in the Array");
        }
        // BinarySearch Character
        int  BinarySearchCharacter(char[] array, char character)
        {
            int start = 0;
            int end = array.Length -1;
            while(start <= end)
            {
              int mid = (start+end)/2;
                if(character == array[mid])
                {
                    return mid+1; 
                }
                else if(character < array[mid])
                {
                    end = mid -1;
                }
                else if(character > array[mid])
                {
                    start = mid+1;
                }  
            }
            return 0;
        }
    }
}
}


