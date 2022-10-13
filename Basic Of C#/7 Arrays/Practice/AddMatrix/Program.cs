using System;
namespace AddMatrix {
class Program{
    public static void Main(string[] args)
    {
        int i,j;
        int[,] array = new int[25,25];
        int[,] array1 = new int[25,25];
        int[,] array2 = new int [25,25];
        // get matrix size
        System.Console.WriteLine("Input Size of the Square matrix(less than 5) :");
        int  size = Convert.ToInt32(Console.ReadLine());

        // get matrix array1 elemnts
        System.Console.WriteLine("Input Elements of First Matrix :");
        for( i=0;i<size;i++)
        {
            for( j=0;j<size;j++)
            {
                System.Console.WriteLine($"Elemnt -[{i},{j}]: ");
                array[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // get second matrix elements
         System.Console.WriteLine("Input Elements of Second Matrix :");
        for( i=0;i<size;i++)
        {
            for( j=0;j<size;j++)
            {
                System.Console.WriteLine($"Elemnt -[{i},{j}]: ");
                array1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // print/show first matrix

        System.Console.WriteLine("\nThe First Matrix is ");
        for(i=0;i<size;i++)
        {
            Console.Write("\n");
            for(j=0;j<size;j++)
            {
                System.Console.Write($"{array[i,j]} ");
            }
        }

        // print/show Second matrix

        System.Console.WriteLine("\nThe Second Matrix is ");
        for(i=0;i<size;i++)
        {
            Console.Write("\n");
            for(j=0;j<size;j++)
            {
                System.Console.Write($"{array1[i,j]} ");
            }
        }

        // sum of two matrix array and array1.
        for(i=0;i<size;i++)
        {
            for(j=0;j<size;j++)
            {
                array2[i,j] = array[i,j] + array1[i,j];
            }
        }
        // print added matrix array2

        System.Console.WriteLine("\nThe Addtion of Two Matrix is ");
        for(i=0;i<size;i++)
        {
            Console.Write("\n");
            for(j=0;j<size;j++)
            {
                System.Console.Write($"{array2[i,j]} ");
            }
        }
    }
}
}
