using System;
namespace OddNaturalNumber {
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Number Of Term: ");
        int times =Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        System.Console.WriteLine($"The Odd Numbers are: ");
        //  terms times  odd numbers
        
        for(int i=1;i<=times*2;i+=2)  // i+=2  --> increment by 2   times*2 --> number of occurence we want
        {
            System.Console.Write(i+" ");
            sum = sum+i;    
        }
        System.Console.WriteLine($"\nThe Sum of Odd Natural Numbers upto {times} terms: {sum}");

    }
}
}