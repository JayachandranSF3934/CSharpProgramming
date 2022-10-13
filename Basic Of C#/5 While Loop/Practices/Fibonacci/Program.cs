using System;
namespace Fibonacci {
class Program{
    public static void Main(string[] args)
    {   
        int number1 = 0;
        int number2 = 1;
        int temp =0;
        

        Console.WriteLine("Enter Number Terms To be Dispaly");
        int term = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Here is the Fibonacci series upto to {term} terms : ");
        while(temp<term)
        {
            Console.Write(number1+" ");
            int sum = number1 + number2;
            number1= number2;
            number2 =sum;
            temp +=1;
        }
        
    }
}
}