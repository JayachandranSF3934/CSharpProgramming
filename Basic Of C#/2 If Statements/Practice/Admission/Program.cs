using System;
namespace Admission{
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
        double percent = (double)sum/300*100;

        if(percent > 75)
        {
            Console.WriteLine("The candidate is eligible for admission.");
        }
        else
        {
          Console.WriteLine("The candidate is NOT eligible for admission.");  
        }
        
    }
}
}