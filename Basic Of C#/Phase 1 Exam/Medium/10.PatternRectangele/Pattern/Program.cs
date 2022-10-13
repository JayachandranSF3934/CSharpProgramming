using System;
namespace Pattern {
class Program{
    public static void Main(string[] args)
    {
        int row =6;int column = 4;

        for(int i=1;i<=row;i++)
        {
            for(int j=1;j<=column;j++)
            {
                System.Console.Write("*");
            }
        }
    }
}
}
