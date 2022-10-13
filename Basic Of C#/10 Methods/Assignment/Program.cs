using System;
namespace Assignment {
class Program{
    public static void Main(string[] args)
    {
        string condition =" ";
        do{
        // Get Option
        System.Console.WriteLine("Choose an Option To be performed");
        Console.WriteLine("1.Addition \n2.Subtraction \n3.Multiplication \n4.Division");
        int menu = Convert.ToInt32(Console.ReadLine());
        // get  Two Number
        Console.WriteLine("Enter First Number");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        int number2 = Convert.ToInt32(Console.ReadLine());
    // switch choices
        switch(menu)
        {
            case 1 :
            {
                Console.WriteLine($"The addition of {number1} and {number2} is {Addition(number1,number2)}");
                break;
            }
            case 2 :
            {
                Console.WriteLine($"The Subtraction of {number1} and {number2} is {Subtraction(number1,number2)}");
                break;
            }
            case 3 :
            {
                Console.WriteLine($"The Multiplication of {number1} and {number2} is {Multiplication(number1,number2)}");
                break;
            }
            case 4 :
            {
                Console.WriteLine($"The Division of {number1} and {number2} is {Division(number1,number2)}");
                break;
            }
        }
        System.Console.WriteLine("Do You Want to Continue Yes or No:");
        condition = Console.ReadLine().ToLower();
        }while(condition == "yes");

        // add
        int Addition (int value1 ,int value2)
        {
            int sum =0;
            sum =value1+value2;
            return sum;
        }
        //sub
        int Subtraction(int value1 ,int value2)
        {
            int subtract =0;
            subtract =value1-value2;
            return subtract;
        }
        //multiply
        int Multiplication(int value1 ,int value2)
        {
            int multiply =0;
            multiply =value1*value2;
            return multiply;
        } 
        // division
        int Division(int value1 ,int value2)
        {
            int division =0;
            division =value1/value2;
            return division;
        }     
    }
}
}