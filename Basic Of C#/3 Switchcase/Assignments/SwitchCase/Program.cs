using System;
namespace SwitchCase{
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter First Number");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Second Number");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Enter Choice +  -  *  /  % ");
        string choice = Console.ReadLine();

        switch(choice){
            case "+":{
             int add = number1 + number2;
             Console.WriteLine(add);
            break;}

             case "-":{
             int sub = number1 - number2;
             Console.WriteLine(sub);
            break;}

            case "*":{
             int mul = number1 * number2;
             Console.WriteLine(mul);
            break;}

            case "/":{
             int div = number1 / number2;
             Console.WriteLine(div);
            break;}

            case "%":{
             int mod = number1 % number2;
             Console.WriteLine(mod);
            break;}

            default:{
                Console.WriteLine("Invaild Operation");
                break;
            }

            

        } 

    }
}
}