using System;
namespace PrimeNumber{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Number to check whether it is prime or Not:");
        int number = Convert.ToInt32( Console.ReadLine());
        int count =0;

        for (int i=2;i<=number;i++)
        {
            if (number % i ==0)
            {
               count++;
            }    
        }
        if(count == 1)
        {
            System.Console.WriteLine($"{number} is a Prime Number");
        }
        else
        {
            System.Console.WriteLine($"{number} is Not a Prime Number");
        }
    }
}
}