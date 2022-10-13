using System;
namespace ArmstrongNumber{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Lower Limit:");
        int lower = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Upper Limit:");
        int upper = Convert.ToInt32(Console.ReadLine());
        int reminder,sum =0;  // intialize sum and remainder

        for (int i=lower;i<=upper;i++)
        {
            for( int j=i;j>0;j=j/10)
            {
                reminder = i%10;    
                sum =  (sum*10)+reminder;
                i = i/10;
                System.Console.WriteLine(sum);
            }
            

        }
    }
}
}
