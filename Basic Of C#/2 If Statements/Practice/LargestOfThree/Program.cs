using System;
namespace LargestOfThree {
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter First Number");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Second Number");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Third Number");
        int number3 = Convert.ToInt32(Console.ReadLine());

        if (number1 > number2)
        {
            if(number1 > number3)
            {
                Console.WriteLine("First number is Greatest among three");
            }
            else
            {
                Console.WriteLine("Third number is Greatest among three");
            }
        }
        else 
        {
            if (number2 > number3)
            {
                Console.WriteLine("Second number is Greatest among three");
            }
            else
            {
                Console.WriteLine("Third number is Greatest among three");
            }
        } 
    }
}
}