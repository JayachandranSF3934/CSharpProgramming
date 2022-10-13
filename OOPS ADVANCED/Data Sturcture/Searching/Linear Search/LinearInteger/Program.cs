using System;
namespace LinearInteger{
class Program{
    public static void Main(string[] args)
    {
        // intialize integer array
        int[] array  = new int[]{0,1,4,6,7,9,22,43,6};
        // calling Linearsearch Methos
        LinearSearchInteger(array,22);

// linear search 
        void LinearSearchInteger (int[]integer, int number)
        {
            int count =0;
            for(int i=0;i<integer.Length;i++)
            {
                if(integer[i] == number)
                {
                    count++;
                    System.Console.WriteLine($"\nThe Elelment is Found In the Given Array at position of  {i}\n");
                }
            } 
            if(count ==0) 
            {
                System.Console.WriteLine("Element Not Found"); 
            }      
        }
    }
}
}
