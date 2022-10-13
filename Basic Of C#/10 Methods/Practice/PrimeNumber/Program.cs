using System;
namespace PrimeNumber {
class Program{
    public static void Main(string[] args)
    {
        //Get Number to check prime or not
        System.Console.WriteLine("Enter Number To Check Whether it is Prime Or Not");
        int number =Convert.ToInt32(Console.ReadLine());
        //call PrimeCheck Method
        int result = primeCheck(number);
        if(result ==0)
        {
            System.Console.WriteLine($"{number} is Not a prime Number");
        }
        else
        {
            System.Console.WriteLine($"{number} is a Prime Number ");
        }
        Console.ReadLine();
        
        // Method For Prime
        int primeCheck(int num)
        {
            int i;
            for(i=2;i<num;i++)
            {
                if(num%i ==0)
                {
                    return 0;
                }
            }
            if(i == num)
            {
                return 1;
            }
            return 0;
        }
    }
}
}
