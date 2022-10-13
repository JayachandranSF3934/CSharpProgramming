using System;
namespace SortArray{
class Program{
    public static void Main(string[] args)
    {
        // Get size of the array
        Console.WriteLine("Enter Size of the Array:");
        int size = Convert.ToInt32(Console.ReadLine());

        // create array
        int[] array = new int[size];
        for(int i=0;i<size;i++)
        {
            System.Console.Write($"Enter Elements-{i} :");
            array[i]=Convert.ToInt32(Console.ReadLine());
        }

        System.Console.WriteLine("\nThe Elements of array Before sorted in ascending order:\n ");
        for(int q=0;q<size;q++)
        {
            System.Console.Write($"{array[q]} ");
        }

        // sort array in ascending
        int temp;

        for(int a =0;a<size;a++)
        {
            for(int b = a+1;b<size;b++)
            {
                if(array[a] > array[b])
                {
                    temp = array[a];
                    array[a] =array[b];
                    array[b] = temp;
                }
            }
        }
        System.Console.WriteLine("\nThe Elements of array in sorted ascending order:\n ");
        for(int f=0;f<size;f++)
        {
            System.Console.Write($"{array[f]} ");
        }

    }
}
}
