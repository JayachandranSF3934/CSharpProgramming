 using System;
namespace Assignemnt2{
class Program{
    public static void Main(string[] args)
    {
        int number = 0;
        string value = " ";
        do
        {
            Console.WriteLine("Input Number To  find odd or Even");
            number = Convert.ToInt32(Console.ReadLine());

            if(number%2==0)
            {
                System.Console.WriteLine("Even");
            }
            else
            {
                System.Console.WriteLine("Odd");
            }

            System.Console.WriteLine("Do You Want To Continue: Yes or NO?");
            value = Console.ReadLine().ToLower();
            
            while(value != "yes" && value !="no")
            {
              System.Console.WriteLine("Input is wrong ,To Continue Type : Yes or NO?");
              value = Console.ReadLine().ToLower();
            }


        }while(value == "yes");
        
    }
}
}