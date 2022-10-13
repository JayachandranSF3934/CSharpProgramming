using System;
namespace FormingArray{
class Program{
    public static void Main(string[] args)
    {
        // intialize 2d array size in 3X3.
        int[,]array = new int[3,3];

        // get array element
        System.Console.WriteLine("Enter Elements of Array");
        for(int a=0;a<3;a++)
        {
            for(int b=0;b<3;b++)
            {
                System.Console.WriteLine($"Enter Elements-[{a},{b}] :");
                array[a,b] =Convert.ToInt32(Console.ReadLine());
            }
        }
            // Print matrix
            
        System.Console.WriteLine("The  3X3 Matirx is:");
        for(int i=0;i<3;i++)
        {
            System.Console.Write("\n");
            for(int j=0;j<3;j++)
            {
                System.Console.Write($"{array[i,j]} ");
            }
            System.Console.Write("\n");
        }
    }
}
}
