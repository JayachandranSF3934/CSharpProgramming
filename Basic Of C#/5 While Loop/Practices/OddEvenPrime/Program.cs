using System;
namespace OddEvenPrime{
class Program{
    public static void Main(string[] args)
    {   
        //Even Numbers
        int range=1;
        Console.WriteLine("Even Numbers in between 1 to 100:");
        while(range<=100)
        {
            if(range%2==0)
            {
                Console.Write($"{range} ");
            }
            range++;
        }
        //Odd Numbers 
        int range1=1;
        Console.WriteLine("\nOdd Numbers in between 1 to 100:");
        while(range1<=100)
        {
            if(range1%2!=0)
            {
                Console.Write($"{range1} ");
            }
            range1++;
        }
        // Prime Numbers

        int range2 =1 ;
        System.Console.WriteLine("\n Prime Numbers in between 1 to 100:");
        while(range2 <=100)
        {
           int count =0; 
           int number =2;
            while(number<=range2/2)
            {
                if(range2%number==0)
                {
                    count++;
                    break;
                }
                number++;
            }
            if(count==0 )
            {
                System.Console.Write($"{range2} ");
            }
            range2++;

        }


    }
}
}