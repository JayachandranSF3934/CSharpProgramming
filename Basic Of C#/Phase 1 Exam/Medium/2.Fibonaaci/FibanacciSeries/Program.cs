using System;
namespace FibonacciSeries {
class Program{
    public static void Main(string[] args)
    {
       
        int number1 = 0;
        int number2 = 1;
        int value =0;
        // get input terms
        Console.Write("Enter Number of Terms To be Displayed:");
        int term = Convert.ToInt32(Console.ReadLine());
        // Fibonacci Series
        while(value<term)
        {
            Console.Write(number1+" ");
            int sum = number1 + number2;
            number1= number2;
            number2 =sum;
            value +=1;
        }    
    }
}
}
