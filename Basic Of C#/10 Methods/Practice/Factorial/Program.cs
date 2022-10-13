using System;
namespace Factorial {
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter A Number To Find Factorial ");
        int factorialNumber = Convert.ToInt32(Console.ReadLine());
        int number = factorial(factorialNumber);
        Console.Write($"The Factorial of {factorialNumber} is {number}");
        Console.ReadLine();

        int factorial(int num)
        {
            int fact =1;
            for(int i=1;i<=num;i++)
            {
                fact = fact*i;
            } return fact;
            
        }
    }
}
}
