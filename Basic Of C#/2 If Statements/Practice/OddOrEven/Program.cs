using System;
namespace OddOrEven{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter The Number To be Checked Whether Odd Or Even:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0){
            Console.WriteLine($"{number } is a Even Integer");
        }else{
            Console.WriteLine($"{number} is a Odd Integer");
        }
        
    }
}
}
