 using System;
namespace Assignemnt2{
class Program{
    public static void Main(string[] args)
    {
        int number = 0;
      
         
        do
        {
            Console.WriteLine("Input Number:");
            number = Convert.ToInt32(Console.ReadLine());

            if(number>0 && number<=10)
            {
                Console.WriteLine("OutPut:"+number);
            }
        }while(number>10);
        
    }
}
}