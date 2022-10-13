using System;
namespace OddOrEven {
class Program{
    public static void Main(string[] args)
    {   
         string choice = " ";
        do
        {
            System.Console.WriteLine("Enter Number to find it is Odd or Even: ");
            int number = int.Parse(Console.ReadLine());

            if(number%2==0)
            {
                System.Console.WriteLine("Entered Number is  Even.");
            }
            else
            {
                System.Console.WriteLine("Entered Number is Odd.");
            }

            Console.WriteLine("Input Choice: Yes or No ?");
            choice =Console.ReadLine().ToLower();

            while(choice != "yes" && choice !="no")
            {
                System.Console.WriteLine("Invaild String Enter Yes or No?");
                choice =Console.ReadLine().ToLower();
            }
            
        }while(choice == "yes");      
    }
}
}