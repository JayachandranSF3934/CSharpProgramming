using System;
namespace GradeCalculator{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter The Mark To Know Your Grade");
        int mark = Convert.ToInt32(Console.ReadLine());

        if(mark > 80 && mark <= 100){
            Console.WriteLine("Your Grade is A");
        } else if(mark > 60 && mark <= 80){
            Console.WriteLine("Your Grade is B");

        }else if(mark > 35 && mark <= 60){
            Console.WriteLine("Your Grade is C");
        }else if(mark <= 35){
            Console.WriteLine("Your Grade id D");
        }else{
            Console.WriteLine("Invaild input");
        }
        }

    }
}