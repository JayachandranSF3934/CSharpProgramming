using System;
namespace XPowerY{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Value of X");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Value of Y");
        int y = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine(power( x , y));
        
     
        // Method for power
         int power(int x, int n)
          {
          int pow = 1;
             // Multiply x for n times
           for (int i = 0; i < n; i++) 
            {
              pow = pow * x;
            }
            return pow;
           }
        
    }
}
}
