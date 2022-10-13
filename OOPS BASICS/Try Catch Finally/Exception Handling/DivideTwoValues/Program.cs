using System;
namespace DivideTwoValues {
class Program{
    public static void Main(string[] args)
    {
        try {
        Console.WriteLine("Enter First Number:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int divide = number1/number2;
        System.Console.WriteLine(divide);
        }catch(DivideByZeroException e)   // format Exception
        {
            System.Console.WriteLine($" An Exception occured :{e.Message}  and {e.StackTrace}");
        }catch(Exception e)  // Genreal  Exception.
        {
            System.Console.WriteLine(e.Message);
        }finally
        {
            System.Console.WriteLine(" Problem Solved");
        }

    }
}
}
