using System;
namespace Fibonacci{
class Program{
    public static void Main(string[] args)
    {  
        // Get NUmber of times Fibonnaci series to be printed
        System.Console.WriteLine("Enter number of Fibonacci Series ");
        int num = Convert.ToInt32(Console.ReadLine());
        // Call Fibonacciseirs Method to  print next elements of series
        System.Console.WriteLine($"The Fiboancci Series of {num} number is :");
        for(int i=0;i<num;i++)
        {
            System.Console.Write(FibonacciSeries(i) + " ");
        }
        Console.ReadLine();

// Method for Fibaonacci
      int FibonacciSeries(int number)
      {
        int number1 = 0;
        int number2 = 1;
        // Next Elements of Fibonacci Series
        for(int i=0;i<number;i++)
        {
            int temp = number1;   // temp =0
            number1= number2; // number1=1
            number2 = temp+number2; // number2 = 0+1
        }
        return number1;   // return 1
      }  
     
    }
}
}