using System;
namespace assignment {
class Program{
    public static void Main(string[] args)
    { int i =0;
    //Exercise 2
        while(i<25)
        {

             if(i%2==0)
             {
                Console.WriteLine(i);
             }
        i++;
        }

        //Excercise 2
         int number;
         Console.WriteLine("Enter Valid number:");
         bool value = int.TryParse(Console.ReadLine(),out number);
         
         while (!value )
         {
            Console.WriteLine("Invalid input format. Please enter the input in number format");
            value = int.TryParse(Console.ReadLine(),out number);
            
         }
         Console.WriteLine(number);
    }
}
}