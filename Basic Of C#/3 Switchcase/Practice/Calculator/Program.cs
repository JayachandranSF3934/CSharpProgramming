using System;
namespace  Calculator{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter The First Integer:");
        int integer1 = Convert.ToInt32( Console.ReadLine());

         Console.WriteLine("Enter The Second Integer:");
        int integer2 = Convert.ToInt32( Console.ReadLine());

        Console.WriteLine("MENU \n1.Addition.\n2.Subtration.\n3.Multiplication.\n4.Division.\n5.Exit ");
        int menu = Convert.ToInt32( Console.ReadLine());

        switch (menu)
        {
            case 1 :
            Console.WriteLine($"Addition of {integer1} and {integer2} is {integer1+integer2}");
            break;

            case 2 :
            Console.WriteLine($"Subtraction of {integer1} and {integer2} is {integer1-integer2}");
            break;

            case 3 :
            Console.WriteLine($"Multiplication of {integer1} and {integer2} is {integer1*integer2}");
            break;

            case 4 :
            Console.WriteLine($"Division of {integer1} and {integer2} is {integer1/integer2}");
            break;

            case 5 :
            Console.WriteLine("Exit");
            break;

            default:
            Console.WriteLine("Invalid");
            break;        
        }


       

    }
}
}