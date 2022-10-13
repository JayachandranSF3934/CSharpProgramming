using System;
namespace Calculator {
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter Input 1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Input 2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Operation Of Calculator");
        System.Console.WriteLine($"Addtion: {Addition(number1,number2)}");
        System.Console.WriteLine($"Subtraction: {Subtraction(number1,number2)}");
        System.Console.WriteLine($"Multiplication:{Multiplication(number1,number2)}");
        System.Console.WriteLine($"Division:{Division(number1,number2)}");




         // add
        int Addition (int value1 ,int value2)
        {
            int sum =0;
            sum =value1+value2;
            return sum;
        }
        //sub
        int Subtraction(int value1 ,int value2)
        {
            int subtract =0;
            subtract =value1-value2;
            return subtract;
        }
        //multiply
        int Multiplication(int value1 ,int value2)
        {
            int multiply =0;
            multiply =value1*value2;
            return multiply;
        } 
        // division
        int Division(int value1 ,int value2)
        {
            int divide =0;
            divide =value1/value2;
            return divide;
        } 

    }
}
}