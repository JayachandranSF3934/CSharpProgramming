using System;
namespace TryParse {
class Program{
    public static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Enter Valid Number");
        bool number =int.TryParse(Console.ReadLine(), out num);
        
        while(number == false)
        {
            Console.WriteLine("Invalid Input Enter Again");
            number = int.TryParse(Console.ReadLine(),out num);
        }
        Console.WriteLine($"{num} is Valid Number");
    }
}
}