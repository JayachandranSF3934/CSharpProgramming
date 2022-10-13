using System;
namespace PatternPyramidNumber {
class Program{
    public static void Main(string[] args)
    {
        int count =4;   // intialize row size .
        for(int i=1;i<=count;i++)     // loop for rows
        {
            for(int j=count-i; j>=1;j--)  // loop for  empty space
            {
                Console.Write(" ");
            }
            for(int k=1;k<=i;k++)   // loop for astericks
            {
                System.Console.Write("* ");  
            }
            System.Console.WriteLine();
        }
    }
}
}