using System;
namespace SumAndAverage{
    class Program {
        public static void Main(string[] args)
        {
            int number = 10;
            int sum =0;
            
            for(int i=1;i<=number;i++)
            {
                System.Console.WriteLine($"Enter Number {i}:");
                int read = Convert.ToInt32(Console.ReadLine());
                sum = sum + read; 
            }
            Console.WriteLine("Sum:"+sum);
            double average = (double)sum / number;
            Console.WriteLine("Average: "+average);
                
        }
    }
}