using System;
namespace Votecasting {
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Your Age:");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age > 18 ){
            Console.WriteLine("Congratulation!!");
            Console.WriteLine("You Are Eligible for Casting Your Vote");
        }else{
            Console.WriteLine("You Are Not Eligible For Casting Your Vote Wait for your time.")
        }
    }
}
}