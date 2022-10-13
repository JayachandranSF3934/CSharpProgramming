using System;
namespace Palindrome {
class Program{
    public static void Main(string[] args)
    {
       int number = 121;
        int sum =0;
        while(number>0)
        {
            int remainder = number%10;
            sum = remainder + sum*10;
            int remain = number/10;  
        }


        if(sum == number )
        {
            System.Console.WriteLine($"The Entered {number} Number is a Palindrome");
        }
        else
        {
            System.Console.WriteLine("The Entered NUmber is Not A Plaindrome");
        }
    }
}
}
