using System;
namespace SwapNumbers{
class Program{
    public static void Main(string[] args)
    { 
        //calling swap method
        SwapNumbers();
        // swap method  witharuguments without return type
        void SwapNumbers()

        {
            Console.Write("Enter a  number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());  
            int temp =0;

             temp =number1;
             number1=number2;
             number2 = temp;

             System.Console.WriteLine($"Now the first Number is {number1}, and the 2nd number is {number2} ");

        }
    }
}
}