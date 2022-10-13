using System;
namespace FunctionDelegate{
class Program{

    // Function Delegates

    static double Sum(int a, int b){return a+b;}
    static double Substract(int a,int b){return a-b;}

    // Delegate method with function delegate

    static double Calculator(Func<int, int, double> operation ,int x, int y)
    {
    return operation(x,y);
    }
    public static void Main(string[] args)
    {
        // calling function delegate

        System.Console.WriteLine(Calculator(Sum,10,10));
        System.Console.WriteLine(Calculator(Substract,10,20));
    }
}
}
