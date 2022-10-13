using System;
namespace CheckNumbers{
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter Integers to find the range:");
        int integer  = Convert.ToInt32(Console.ReadLine());
        
        // checking range
        if(integer < 100)
        {
            System.Console.WriteLine($"\n{integer} is Less than 100 ");
        }
        else if(integer >= 100 && integer <200)
        {
            System.Console.WriteLine($"\n{integer} is Between 100 and 200 ");
        }
        else if(integer >200)
        {
            System.Console.WriteLine($"\n{integer} is Greater than 200");
        }
    }
}
}
