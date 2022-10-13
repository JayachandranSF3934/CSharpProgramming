using System;
namespace PatternRightAngle{
class Program{
    public static void Main(string[] args)
    {
    // pattern 
        for(int i=1;i<=4;i++)  // loop 1 --> rows 
        {
            for(int j=1;j<=i;j++)  // loop 2--> column 
            {
                Console.Write("*");   // values to be printed 
            } Console.WriteLine(" ");
        }
        
    }
}
}