 using System;
namespace Assignemnt2{
class Program{
    public static void Main(string[] args)
    {
        int number = 0;
        int sum =0;
        
        do
        {
            sum +=number;
            System.Console.WriteLine("Enter Number:");
            number =Convert.ToInt32(Console.ReadLine());
        }
        while(number >=0);
        System.Console.WriteLine($"The Sum is {sum}");
        
        
    }
}
}