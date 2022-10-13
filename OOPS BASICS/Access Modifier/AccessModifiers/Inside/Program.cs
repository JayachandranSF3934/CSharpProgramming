using System;
namespace Inside{
class Program{
    public static void Main(string[] args)
    {
        First one  = new First();
        System.Console.WriteLine(one.PublicNumber);
       // System.Console.WriteLine(one.PrivateNumber);
       // Use Property to get private number outside class.
       System.Console.WriteLine(one.PrivateNumber2);
       System.Console.WriteLine(one.InternalNumber);

       //System.Console.WriteLine(one.ProtectedNumber);
       // Use Property to get Protected Number outside class
       second two = new second();
       System.Console.WriteLine(two.ProtectedOutput);

       System.Console.WriteLine(two.ProtectedInternal2);
    }
}
}
