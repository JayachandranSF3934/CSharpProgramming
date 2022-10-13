using System;
namespace Count{
class Program{
    public static void Main(string[] args)
    {
        int count =0;
        int number = 1;
        Console.WriteLine("Enter Count value: ");
        count = Convert.ToInt32(Console.ReadLine());

        while(number <= count)
        {
            Console.Write(number +" ");
            number++;            
        }
        
        
        
    }
}
}