using System;
namespace SingleCastingDelegate{

    // Delegates must be  declaerd at below  namespace and above class 
    public delegate int Calculator(int n);  //  can add methods having int type only

class Program{
    // feild
    static int value = 10;
    
    public static int AddNum(int number) {  value += number; return value; }
    public static int MulNum(int number) {  value *= number; return value; }
    public static int  GetNumber() { return value; }


    static void Main(string[] args)
    {
        // Create Delegates   // de
        Calculator  newcal = new Calculator(AddNum);
        Calculator nwecal2 = new Calculator(MulNum);

        // calling 
        newcal(25);
        System.Console.WriteLine($" {GetNumber()}");
        nwecal2(5);
        System.Console.WriteLine($" {GetNumber()}");
        
    }
}
}
