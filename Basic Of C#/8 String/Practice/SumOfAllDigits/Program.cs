using System;
namespace SumOfAllDigits{
class Program{
    public static void Main(string[] args)
    {
        // Get string from the user
        Console.WriteLine("Enter the sting ");
        string input = Console.ReadLine();
        int sum =0;
        int n = input.Length;

        //Check the string contains digits 

        for( int i=0;i<n;i++)
        {
            if((input[i] >= '0' && input[i] <= '9'))
            {
                sum += (input[i] -'0');
            }
        }
        System.Console.WriteLine($"sum = {sum}");
       
    }
}
}
