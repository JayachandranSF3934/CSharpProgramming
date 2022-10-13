using System;
namespace PatternPyramidNumber {
class Program{
    public static void Main(string[] args)
    {
         int count =4, integer =1;   // intialize row size or  and integer.

         for(int i=1;i<=count;i++)     // loop for rows
         {
            for(int j=count-i; j>=1;j--)  // loop for  empty space
            {
                Console.Write(" ");
            }
            for(int k=1;k<=i;k++)   // loop for integer
            {
                System.Console.Write($"{integer++} ");  // increment integer
            }
            System.Console.WriteLine();
         }
    }
}
}