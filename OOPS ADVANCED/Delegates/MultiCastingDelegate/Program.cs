using System;
namespace MultiCastingDelegate{

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
        // muti delegates

        // create delegeate instance

        Calculator cal;
        Calculator cal1=new Calculator(AddNum);
        Calculator cal2= new Calculator(MulNum);

        cal = cal1;
        cal +=cal2;  // cal= cal+cal2 // all values are stored in cal , if we call the cal it executes methods inside the cal.Its runs when method is called.
        
        cal(5);
        System.Console.WriteLine($"{GetNumber()}");
    }
}
}
