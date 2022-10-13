using System;
namespace ForLoop{
class Program{
    public static void Main(string[] args)
    {
        //Excercise 1
       for(int i=0;i<=25;i++)
       {
        if(i%2==0)
        {
        Console.WriteLine(i);
        }
       }
       
       // Excercise 2
       Console.WriteLine("Enter Intial Value:");
       int intial = Convert.ToInt32(Console.ReadLine());

       Console.WriteLine("Enter Final Value:");
       int final = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        
       for(int i=intial; i<=final;i++){     
        sum = sum +(i)*(i); 
       } Console.WriteLine("The Sum of a square of number"+sum);
    }
}
}