using System;
namespace addSubMulDiv;
class Program 
{
public static void Main(string[] args)
{
    Console.WriteLine("Input the first Number: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the second  Number: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    //Addition
    int addtion = number1 + number2;
    Console.WriteLine("Addtion: " +addtion);
   // Console.WriteLine($"{number1} + {number2} = {}");
   //Sub
   int subtract = number1 - number2;
    Console.WriteLine("Subtract: " +subtract);
   
   // Multiply
   int multiply = number1 * number2;
    Console.WriteLine("multiply: " +multiply);

    // Divide
    int divide = number1 / number2;
    Console.WriteLine("divide: " + divide);

    //modulo
    int modulo = number1 % number2;
    Console.WriteLine("modulo: " +modulo);
}
}