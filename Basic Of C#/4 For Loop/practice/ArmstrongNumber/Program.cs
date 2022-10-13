using System;
namespace ArmstrongNumber{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number to Check Whether it is armstrong or not: ");
        int number =Convert.ToInt32(Console.ReadLine());
        int reminder,sum =0;  // intialize sum and remainder

        for(int i=number; i>0; i= i/10)  //  loop for Armstrong   ( number is grater than 0 means iterate digit after digit by using /10)
        {
            reminder = i%10;    // remainder using modulo
            sum = sum + reminder*reminder*reminder;  //  sum = remainder^3 +sum
        }
        if(sum == number)
        {
            System.Console.WriteLine($"{number} is a Armstrong Number");
        }
        else
        {
            System.Console.WriteLine($"{number} is Not a Armstrong Number");
        }
    }
}
}