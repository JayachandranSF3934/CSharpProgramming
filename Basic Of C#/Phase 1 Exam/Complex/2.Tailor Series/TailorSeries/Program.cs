using System;
namespace TailorSeries{
class Program{
    public static void Main(string[] args)
    {
    
      System.Console.WriteLine("The  Tailor Series up to 8");
      System.Console.Write($"1+2 +2^2/2!+ 2^3/3!+ 2^4/4!+ 2^5/5!+ 2^6/6!+ 2^7/7!+ 2^8/8!");
      int value =  



      



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
    // Method for Factorial
    int factorial(int a)
    {
         int fact =1;
         for(int i=a;i>0;i--)
         {
            fact = fact*i;
         }
         return fact;
    } 
}
}
}

