using System;
namespace SumAndAverage {
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your Physics Marks: ");
        int phymark = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your Chemistry Marks: ");
        int chemark = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your Mathematics Marks: ");
        int mathmark = Convert.ToInt32(Console.ReadLine());

        int sum = (phymark+chemark+mathmark);
        Console.WriteLine("Sum is "+sum);

        double percent = (double)sum/300*100;
        Console.WriteLine("Percentage of the Given Subjects are: "+percent);
        
    }
}
}