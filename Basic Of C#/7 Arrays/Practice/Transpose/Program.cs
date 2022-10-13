using System;
namespace Transpose {
class Program{
    public static void Main(string[] args)
    {
        // get row and colums
        int i,j,row, column;
        Console.WriteLine("Input the rows  of the matrix : ");
        row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the  columns of the matrix : ");
        column = Convert.ToInt32(Console.ReadLine());
        // intialize new array
        int[,] array = new int[10,10];

        // get matrix element

        for(i=0;i<row;i++)
        {
            for(j=0;j<column;j++)
            {
                System.Console.WriteLine($"Elemnt of matrix {row}X{column} -[{i},{j}]: ");
                array[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // print matrix before transpose

        System.Console.WriteLine("\nThe Matrix is :");
        for(i=0;i<row;i++)
        {
            Console.Write("\n");
            for(j=0;j<column;j++)
            {
                System.Console.Write($"{array[i,j]} ");
            }
        }
        // Print matrix after transpose
        System.Console.WriteLine(" \nThe Transpose of a Matrix is :");
        for(i=0;i<row;i++)
        {
            Console.Write("\n");
            for(j=0;j<column;j++)
            {
                System.Console.Write($"{array[j,i]} ");
            }
        }

        
    }
}
}